const vm = Vue.createApp({
    data() {
        return {
            users: [],
            roles: [
                { id: 2, name: "Öğrenci" },
                { id: 3, name: "Admin" }
            ],
            pagination: {
                page: 0,
                size: 10,
                count: 0,
                pages: 0
            },
            form: this.emptyForm(),
            filters: {
                search: "",
                roleId: ""
            }
        }
    },

    computed: {
        filteredUsers() {
            return this.users;
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
                username: "",
                phone: "",
                birthDate: "",
                ogrenciNo: "",
                password: "123123Aa"
            };
        },

        getSelectedRoleId() {
            return Number(this.form.roleId || this.form.rolId || 0);
        },

        isStudentRole() {
            return this.getSelectedRoleId() === 2;
        },

        isAdminRole() {
            return this.getSelectedRoleId() === 3;
        },

        getRoleId(user) {
            return Number(user.roleId || user.rolId || user.RoleId || 0);
        },

        isAdmin(user) {
            return this.getRoleId(user) === 3 ||
                (user.roleName || "").toLowerCase() === "admin";
        },

        isStudent(user) {
            return this.getRoleId(user) === 2;
        },

        getRoleName(user) {
            if (user.roleName) return user.roleName;

            const role = this.roles.find(x => x.id === this.getRoleId(user));
            return role ? role.name : "-";
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

            this.form.phone = value.substring(0, 11);
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
                const params = new URLSearchParams();

                params.append("page", this.pagination.page);
                params.append("size", this.pagination.size);

                if (this.filters.search) {
                    params.append("search", this.filters.search);
                }

                if (this.filters.roleId) {
                    params.append("roleId", this.filters.roleId);
                }

                const response = await fetch(`/User/GetUsersPaginated?${params.toString()}`);
                const result = await response.json();

                if (result.isSuccess || result.success) {
                    const data = result.data;

                    if (Array.isArray(data)) {
                        this.users = data;
                        this.pagination.count = data.length;
                        this.pagination.pages = 0;
                        this.pagination.page = 0;
                    } else {
                        this.users = data.items || data.Items || [];
                        this.pagination.count = data.count || data.Count || 0;
                        this.pagination.pages = data.pages || data.Pages || 0;
                        this.pagination.page = data.index || data.Index || 0;
                        this.pagination.size = data.size || data.Size || 10;
                    }
                } else {
                    await this.showError(result.message || "Kullanıcılar getirilemedi.");
                }
            } catch (err) {
                console.error(err);
                await this.showError("Kullanıcılar getirilirken bir hata oluştu.");
            }
        }, changePage(page) {
            if (page < 0 || page >= this.pagination.pages) return;

            this.pagination.page = page;
            this.getUsers();
        },

        async applyFilters() {
            this.pagination.page = 0;
            await this.getUsers();
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

            if (this.form.phone.length !== 11 || !this.form.phone.startsWith("0")) {
                return "Telefon numarası 0 ile başlayan 11 haneli olmalıdır.";
            }
            if (!this.form.roleId) {
                return "Rol alanı zorunludur.";
            }

            if (this.isStudentRole()) {
                if (!this.form.ogrenciNo || this.form.ogrenciNo.trim() === "") {
                    return "Öğrenci numarası zorunludur.";
                }
                if (!this.form.username || this.form.username.trim() === "") {
                    return "Kullanıcı adı zorunludur.";
                }
            }

            return null;
        },

        createPayload() {
            const roleId = this.getSelectedRoleId();
            const fullName = `${this.form.name || ""} ${this.form.surname || ""}`.trim();
            console.log(this.form)
            return {
                id: this.form.id,
                rolId: roleId,
                roleId: roleId,

                name: this.form.name,
                surname: this.form.surname,
                username: this.form.username,
                fullName: fullName,

                phone: this.form.phone,

                birthDate: roleId === 2 ? (this.form.birthDate || null) : null,
                ogrenciNo: roleId === 2 ? (this.form.ogrenciNo || null) : null,

                password: this.form.password || "123123Aa",
                passwordRepeat: this.form.password || "123123Aa"
            };
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
                payload.passwordRepeat = "123123Aa";
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
            const roleId = this.getRoleId(user);
            console.log(user)
            this.form = {
                id: user.id,

                roleId: roleId,
                rolId: roleId,

                name: user.name || user.Name || "",
                surname: user.surname || user.Surname || "",
                username: user.userName || user.UserName || "",

                phone: user.phone || user.Phone || "",

                birthDate: user.birthDate || user.BirthDate || "",
                ogrenciNo: user.ogrenciNo || user.OgrenciNo || "",

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
                html: `<b>${user.userName || this.formatDisplayPhone(user.phone)}</b> kullanıcısı için yeni şifre giriniz.`,
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