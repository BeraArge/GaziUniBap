

const vm = Vue.createApp({
    data() {
        return {
            users: [],

            roles: [
                { id: 2, name: "Admin" },
                { id: 3, name: "Kullanıcı" }
            ],

            form: this.emptyForm(),

            filters: {
                search: "",
                roleId: ""
            }
        }
    },

    computed: {
        filteredUsers() {
            const search = (this.filters.search || "").toLowerCase();

            return this.users.filter(user => {
                const matchSearch =
                    !search ||
                    (user.fullName || "").toLowerCase().includes(search) ||
                    (user.phone || "").toLowerCase().includes(search) ||
                    (user.ogrenciNo || "").toLowerCase().includes(search) ||
                    (user.roleName || "").toLowerCase().includes(search);

                const matchRole =
                    !this.filters.roleId ||
                    user.roleId == this.filters.roleId ||
                    user.rolId == this.filters.roleId;

                return matchSearch && matchRole;
            });
        }
    },

    async mounted() {
        await this.getUsers();
    },

    methods: {
        emptyForm() {
            return {
                id: null,
                roleId: "",
                rolId: "",
                name: "",
                surname: "",
                fullName: "",
                phone: "",
                birthDate: "",
                ogrenciNo: "",
                password: "123123Aa"
            };
        }, 

        isStudentRole() {
            return Number(this.form.roleId || this.form.rolId) === 2;
        },

        isAdminRole() {
            return Number(this.form.roleId || this.form.rolId) === 1;
        },

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
            let value = e.target.value || "";

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
            if (!phone) return "-";

            let p = phone.startsWith("90") ? phone.substring(2) : phone;

            if (p.length > 10) {
                p = p.substring(0, 10);
            }

            if (p.length !== 10) return p;

            return `${p.substring(0, 3)} ${p.substring(3, 6)} ${p.substring(6, 8)} ${p.substring(8, 10)}`;
        },

        getRoleId(user) {
            return user.roleId || user.rolId;
        },

        isAdmin(user) {
            return this.getRoleId(user) == 1 ||
                (user.roleName || "").toLowerCase() === "admin";
        },

        isStudent(user) {
            console.log("evetr")
            return this.getRoleId(user) == 2;
        },

        getRoleName(user) {
            if (user.roleName) return user.roleName;

            const roleId = this.getRoleId(user);
            const role = this.roles.find(x => x.id == roleId);

            return role ? role.name : "-";
        },

        getInitials(name) {
            if (!name) return "?";

            return name
                .split(" ")
                .filter(x => x)
                .slice(0, 2)
                .map(x => x[0])
                .join("")
                .toUpperCase();
        },

        async getUsers() {
            try {
                const response = await fetch("/User/GetUsers");
                const result = await response.json();

                if (result.isSuccess || result.success) {
                    this.users = result.data || [];
                } else {
                    await this.showError(result.message || "Kullanıcılar getirilemedi.");
                }
            } catch (err) {
                console.error(err);
                await this.showError("Kullanıcılar getirilirken bir hata oluştu.");
            }
        },

        validateForm() {
            if (!this.form.name || this.form.name.trim() === "") {
                return "Ad zorunludur.";
            }

            if (!this.form.surname || this.form.surname.trim() === "") {
                return "Soyad zorunludur.";
            }

            if (!this.form.phone || this.form.phone.trim() === "") {
                return "Telefon numarası zorunludur.";
            }

            if (this.form.phone.length !== 10) {
                return "Telefon numarası 90 hariç 10 haneli olmalıdır.";
            }

            if (!this.form.roleId) {
                return "Rol alanı zorunludur.";
            }

            if (this.isStudentRole()) {
                if (!this.form.ogrenciNo || this.form.ogrenciNo.trim() === "") {
                    return "Öğrenci numarası zorunludur.";
                }
            }

            return null;
        },

        createPayload() {
            const roleId = Number(this.form.roleId);

            const fullName = `${this.form.name || ""} ${this.form.surname || ""}`.trim();

            const payload = {
                id: this.form.id,
                rolId: roleId,
                roleId: roleId,

                name: this.form.name,
                surname: this.form.surname,
                fullName: fullName,

                phone: this.form.phone,
                birthDate: roleId === 3 ? (this.form.birthDate || null) : null,
                ogrenciNo: roleId === 3 ? (this.form.ogrenciNo || null) : null,

                password: this.form.password || "123123Aa",
                passwordRepeat: this.form.password || "123123Aa"
            };

            return payload;
        },

        async saveUser() {
            const validationMessage = this.validateForm();

            if (validationMessage) {
                await this.showError(validationMessage);
                return;
            }

            const url = this.form.id
                ? "/User/UpdateUser"
                : "/User/CreateUser";

            const payload = this.createPayload();

            if (!this.form.id) {
                payload.password = "123123Aa";
            }

            try {
                const response = await fetch(url, {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(payload)
                });

                const result = await response.json();

                if (result.isSuccess || result.success) {
                    await this.showSuccess(result.message || "İşlem başarılı.");
                    this.clearForm();
                    await this.getUsers();
                } else {
                    await this.showError(result.message || "İşlem başarısız.");
                }
            } catch (err) {
                console.error(err);
                await this.showError("Kayıt işlemi sırasında bir hata oluştu.");
            }
        },

        editUser(user) {
            console.log(user)
            this.form = {
                id: user.id,

                roleId: user.roleId || user.rolId || "",
                rolId: user.roleId || user.rolId || "",

                name: user.name || "",
                surname: user.surname || "",
                fullName: user.fullName || "",

                phone: user.phone?.startsWith("90")
                    ? user.phone.substring(2)
                    : user.phone || "",

                birthDate: user.birthDate || "",
                ogrenciNo: user.ogrenciNo || "",

                password: ""
            };

            window.scrollTo({
                top: 0,
                behavior: "smooth"
            });
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

                if (result.isSuccess || result.success) {
                    await this.showSuccess(result.message || "Kullanıcı silindi.");
                    await this.getUsers();
                } else {
                    await this.showError(result.message || "Kullanıcı silinemedi.");
                }
            } catch (err) {
                console.error(err);
                await this.showError("Silme işlemi sırasında bir hata oluştu.");
            }
        },

        async openPasswordModal(user) {
            const result = await Swal.fire({
                icon: "warning",
                title: "Şifre Resetleme",
                html: `<b>${user.fullName || this.formatDisplayPhone(user.phone)}</b> kullanıcısı için yeni şifre giriniz.`,
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

                if (resetResult.isSuccess || resetResult.success) {
                    await this.showSuccess(resetResult.message || "Şifre başarıyla sıfırlandı.");
                    await this.getUsers();
                } else {
                    await this.showError(resetResult.message || "Şifre sıfırlanamadı.");
                }
            } catch (err) {
                console.error(err);
                await this.showError("Şifre sıfırlama sırasında bir hata oluştu.");
            }
        },

        clearForm() {
            this.form = this.emptyForm();
        }
    }
}).mount("#app");