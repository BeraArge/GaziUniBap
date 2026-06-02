const vm = Vue.createApp({
    data() {
        return {
            users: [],
            roles: [
                { id: 2, name: "Admin" },
                { id: 3, name: "Kullanıcı" }
            ],
            form: {
                id: null,
                phone: "",
                password: "123123Aa",
                roleId: ""
            },
            filters: {
                search: "",
                roleId: ""
            },
            selectedUser: null
        }
    },

    computed: {
        filteredUsers() {
            return this.users.filter(user => {
                const search = this.filters.search.toLowerCase();

                const matchSearch =
                    !search ||
                    user.phone?.toLowerCase().includes(search) ||
                    user.roleName?.toLowerCase().includes(search);

                const matchRole =
                    !this.filters.roleId ||
                    user.roleId == this.filters.roleId;

                return matchSearch && matchRole;
            });
        }
    },

    async mounted() {
        await this.getUsers();
    },

    methods: {
        showSuccess(message) {
            return Swal.fire({
                icon: "success",
                title: "Başarılı",
                text: message,
                confirmButtonText: "Tamam",
                confirmButtonColor: "#087c8f"
            });
        },

        showError(message) {
            return Swal.fire({
                icon: "error",
                title: "Hata",
                text: message,
                confirmButtonText: "Tamam",
                confirmButtonColor: "#087c8f"
            });
        },

        async showConfirm(message) {
            return await Swal.fire({
                icon: "question",
                title: "Emin misiniz?",
                text: message,
                showCancelButton: true,
                confirmButtonText: "Evet",
                cancelButtonText: "Hayır",
                confirmButtonColor: "#087c8f",
                cancelButtonColor: "#d33"
            });
        },

        formatPhone(e) {
            let value = e.target.value;

            value = value.replace(/\D/g, "");

            if (value.startsWith("0")) {
                value = value.substring(1);
            }

            if (value.length > 10) {
                value = value.substring(0, 10);
            }

            this.form.phone = value;
        },

        formatDisplayPhone(phone) {
            if (!phone) return "";

            let p = phone.startsWith("90") ? phone.substring(2) : phone;

            if (p.length > 10) {
                p = p.substring(0, 10);
            }

            return `${p.substring(0, 3)} ${p.substring(3, 6)} ${p.substring(6, 8)} ${p.substring(8, 10)}`;
        },

        async getUsers() {
            try {
                const response = await fetch("/User/GetUsers");
                const result = await response.json();
                console.log(result)
                if (result.isSuccess) {
                    this.users = result.data;
                } else {
                    await this.showError(result.message || "Kullanıcılar getirilemedi.");
                }
            } catch (err) {
                await this.showError("Kullanıcılar getirilirken bir hata oluştu.");
            }
        },

        async saveUser() {
            if (!this.form.phone || !this.form.roleId) {
                await this.showError("Telefon ve rol alanı zorunludur.");
                return;
            }

            if (this.form.phone.length !== 10) {
                await this.showError("Telefon numarası 90 hariç 10 haneli olmalıdır.");
                return;
            }

            const url = this.form.id
                ? "/User/UpdateUser"
                : "/User/CreateUser";

            const payload = this.form.id
                ? {
                    id: this.form.id,
                    phone: this.form.phone,
                    roleId: Number(this.form.roleId),
                    fullName: this.form.fullName
                }
                : {
                    phone: this.form.phone,
                    password: this.form.password,
                    roleId: Number(this.form.roleId),
                    fullName: this.form.fullName

                };
                console.log(payload)
            try {
                const response = await fetch(url, {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(payload)
                });

                const result = await response.json();

                if (result.isSuccess) {
                    await this.showSuccess(result.message || "İşlem başarılı.");
                    this.clearForm();
                    await this.getUsers();
                } else {
                    await this.showError(result.message || "İşlem başarısız.");
                }
            } catch (err) {
                await this.showError("Kayıt işlemi sırasında bir hata oluştu.");
            }
        },

        editUser(user) {
            this.form.id = user.id;
            this.form.phone = user.phone?.startsWith("90")
                ? user.phone.substring(2)
                : user.phone;
            this.form.roleId = user.roleId;
            this.form.password = "";
        },

        async deleteUser(id) {
            const confirmResult = await this.showConfirm("Bu kullanıcıyı silmek istediğinize emin misiniz?");

            if (!confirmResult.isConfirmed) {
                return;
            }

            try {
                const response = await fetch(`/User/DeleteUser?id=${id}`, {
                    method: "POST"
                });

                const result = await response.json();

                if (result.isSuccess) {
                    await this.showSuccess(result.message || "Kullanıcı silindi.");
                    await this.getUsers();
                } else {
                    await this.showError(result.message || "Kullanıcı silinemedi.");
                }
            } catch (err) {
                await this.showError("Silme işlemi sırasında bir hata oluştu.");
            }
        },

        async openPasswordModal(user) {
            const result = await Swal.fire({
                icon: "warning",
                title: "Şifre Resetleme",
                html: `<b>${this.formatDisplayPhone(user.phone)}</b> kullanıcısı için yeni şifre giriniz.`,
                input: "password",
                inputPlaceholder: "Yeni şifre",
                inputValue: "123123Aa",
                showCancelButton: true,
                confirmButtonText: "Şifreyi Güncelle",
                cancelButtonText: "Vazgeç",
                confirmButtonColor: "#087c8f",
                cancelButtonColor: "#d33",
                inputValidator: (value) => {
                    if (!value) {
                        return "Yeni şifre boş olamaz.";
                    }

                    if (value.length < 8) {
                        return "Şifre en az 8 karakter olmalıdır.";
                    }
                }
            });

            if (!result.isConfirmed) {
                return;
            }

            try {
                const response = await fetch("/User/ResetPassword", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify({
                        id: user.id,
                        newPassword: result.value
                    })
                });

                const resetResult = await response.json();

                if (resetResult.isSuccess) {
                    await this.showSuccess(resetResult.message || "Şifre başarıyla sıfırlandı.");
                    await this.getUsers();
                } else {
                    await this.showError(resetResult.message || "Şifre sıfırlanamadı.");
                }
            } catch (err) {
                await this.showError("Şifre sıfırlama sırasında bir hata oluştu.");
            }
        },

        goDetail(id) {
            window.location.href = `/kullanici_detay/${id}`;
        },

        isAdmin(user) {
            return user.roleName?.toLowerCase() === "admin" ||
                user.roleName?.toLowerCase() === "süper admin" ||
                user.roleId == 1;
        },

        clearForm() {
            this.form = {
                id: null,
                phone: "",
                password: "123123Aa",
                roleId: ""
            };
        }
    },
}).mount("#app");