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
                name: "",
                surname: "",
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

    async mounted() {
        if (window.__initialProfile) {
            this.edit = {
                ...this.edit,
                ...window.__initialProfile,
            };

        }
    },

    methods: {
        showAlert(type, message) {
            this.alert.show = true;
            this.alert.class = (type === "success") ? "alert-success" : "alert-danger";
            this.alert.message = message || "";
            setTimeout(() => this.alert.show = false, 10000);
        },
        editPhoneInput(e) {
            let digits = (e.target.value || "").replace(/\D/g, "");
            if (digits.length > 11) digits = digits.slice(0, 11);

            const formatted = this.formatPhone(digits);
            this.edit.phone = formatted;

            if (e.target.value !== formatted) e.target.value = formatted;
        },
        formatPhone(digits) {
            if (!digits) return "";

            const d1 = digits.slice(0, 1);       
            const d2 = digits.slice(1, 4);       
            const d3 = digits.slice(4, 7);       
            const d4 = digits.slice(7, 9);       
            const d5 = digits.slice(9, 11);      

            let result = d1;

            if (d2) result += " (" + d2;
            if (d2.length === 3) result += ")";
            if (d3) result += " " + d3;
            if (d4) result += " " + d4;
            if (d5) result += " " + d5;

            return result;
        }, 
        formatPhone(e) {
            let value = e.target.value;

            // Sadece sayı bırak
            value = value.replace(/\D/g, '');

            // Maksimum 11 karakter
            value = value.substring(0, 11);

            this.edit.phone = value;
        },
        async saveProfile() {

            this.isSavingEdit = true;
            try {
                if (this.edit.phone.length !== 11) {
                    this.showAlert("Telefon numarası 11 haneli olmalıdır.", "error");
                    return;
                }
                const json = await SendPostRequest("/User/UpdateProfile", this.edit);
                console.log(json)
                if (!json.isSuccess && json.success === false) { 
                    this.showAlert("error", json.message || "Profil güncellenemedi.");
                    return;
                }

                const ok = (json.success === true) || (json.isSuccess === true);
                if (!ok) {
                    this.showAlert("error", json.message || "Profil güncellenemedi.");
                    return;
                }

                this.showAlert("success", json.message || "Profil güncellendi.");
            } catch (e) {
                console.log(e)
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
                if (res.isSuccess==false) {
                    this.showAlert("error", res.message || "Şifre değiştirilemedi.");
                    return;
                }
                this.showAlert("success", res.message || "Şifre güncellendi.");
                this.resetPasswordForm();
            } catch (ee) {
                console.log(ee)
                this.showAlert("error", "Sunucuya erişilemedi.");
            } finally {
                this.isSavingPassword = false;
            }
        }
    }
}).mount("#app");