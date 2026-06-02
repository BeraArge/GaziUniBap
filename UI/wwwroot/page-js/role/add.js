const vm = Vue.createApp({
    data() {
        return {
            role: {
                "name": "",
            },

        }
    },
    async mounted() {
        CloseInitLoader();
    },
    methods: {
        async addRole() {
            let url = "/Role/Create";
            let data = vm.role;
            let result = {};
            try {
                result = await SendPostRequest(url, data);
                if (result.isSuccess == true) {
                    Swal.fire({
                        title: result.message,
                        text: "Rol sayfasına yönlendiriliyorsunuz.",
                        icon: "success",
                        showCancelButton: false,
                        showConfirmButton: true,
                        timer: 2000,
                        willClose: () => {
                            window.location.replace("/Role/Index");
                        }
                    });
                }
            }
            catch (err) {
                HandleCathBlok(err);
            }



        }
    },
}).mount("#app");