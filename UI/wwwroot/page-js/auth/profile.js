const app = Vue.createApp({
    data() {
        return {
            activeTab: "profile",

            alert: { show: false, class: "alert-success", message: "" },

            isSavingEdit: false,
            isSavingPassword: false,

            edit: {
                id: 0,
                roleId: 0,
                rolId: 0,
                name: "",
                surname: "",
                fullName: "",
                phone: "",
                email: "",
                username: ""
            },

            password: {
                oldPassword: "",
                newPassword: "",
                newPasswordRepeat: ""
            }
        };
    },

    mounted() {
        if (window.__initialProfile) {
            const p = window.__initialProfile;

            this.edit = {
                ...this.edit,
                ...p,

                roleId: p.roleId || p.rolId || 0,
                rolId: p.rolId || p.roleId || 0,

                name: p.name || p.Name || "",
                surname: p.surname || p.Surname || "",
                fullName: p.fullName || p.FullName || "",
                phone: p.phone || p.Phone || ""
            };
        }
    },

    methods: {
        getFullName() {
            const name = this.edit.name || "";
            const surname = this.edit.surname || "";

            const fullName = `${name} ${surname}`.trim();

            return fullName || this.edit.fullName || "";
        },

        showAlert(type, message) {
            this.alert.show = true;
            this.alert.class = (type === "success") ? "alert-success" : "alert-danger";
            this.alert.message = message || "";
            setTimeout(() => this.alert.show = false, 10000);
        },

        formatPhone(e) {
            let value = e.target.value || "";

            value = value.replace(/\D/g, "");

            if (value.length > 11) {
                value = value.substring(0, 11);
            }

            this.edit.phone = value;
        },

        async saveProfile() {
            if (!this.edit.name || this.edit.name.trim() === "") {
                this.showAlert("error", "Ad zorunludur.");
                return;
            }

            if (!this.edit.surname || this.edit.surname.trim() === "") {
                this.showAlert("error", "Soyad zorunludur.");
                return;
            }

            if (!this.edit.phone || this.edit.phone.length !== 11) {
                this.showAlert("error", "Telefon numarası 11 haneli olmalıdır.");
                return;
            }

            this.isSavingEdit = true;

            try {
                const payload = {
                    ...this.edit,
                    fullName: this.getFullName()
                };
                const json = await SendPostRequest("/User/UpdateProfile", payload);

                console.log("burda", json)
                const ok = json.success === true || json.isSuccess === true;

                if (!ok) {
                    this.showAlert("error", json.message || "Profil güncellenemedi.");
                    return;
                }

                this.edit.fullName = this.getFullName();

                this.showAlert("success", json.message || "Profil güncellendi.");
            } catch (e) {
                console.log(e);
                this.showAlert("error", "Sunucuya erişilemedi.");
            } finally {
                this.isSavingEdit = false;
            }
        },

        resetPasswordForm() {
            this.password.oldPassword = "";
            this.password.newPassword = "";
            this.password.newPasswordRepeat = "";
        },

        async changePassword() {
            if (!this.password.oldPassword || !this.password.newPassword || !this.password.newPasswordRepeat) {
                this.showAlert("error", "Mevcut şifre ve yeni şifre zorunludur.");
                return;
            }

            if (this.password.newPassword !== this.password.newPasswordRepeat) {
                this.showAlert("error", "Yeni şifre tekrar ile aynı olmalıdır.");
                return;
            }

            this.isSavingPassword = true;

            try {
                const res = await SendPostRequest("/User/UpdatePassword", this.password);

                if (res.isSuccess === false || res.success === false) {
                    this.showAlert("error", res.message || "Şifre değiştirilemedi.");
                    return;
                }

                this.showAlert("success", res.message || "Şifre güncellendi.");
                this.resetPasswordForm();
            } catch (ee) {
                console.log(ee);
                this.showAlert("error", "Sunucuya erişilemedi.");
            } finally {
                this.isSavingPassword = false;
            }
        }
    }
}).mount("#app");