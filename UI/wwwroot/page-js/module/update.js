const app = Vue.createApp({
    data() {
        return {
            module: {
                name: "",
                controller: "",
                action: "",
                address: "",
                icon: "",
                menu: 0,
                parentid: 0
            },
            parentModules: [],
            modulesKeys: []

        }
    },
    async mounted() {
        this.modulesKeys = ModuleKeys ?? [];
        InitIconCollection();
        try {
            const url = `/Module/GetList?id=0`;
            let data = {}
            let result = await SendGetRequest(url, data);
            if (result.isSuccess) {
                app.parentModules = result.data.items;
                //app.modules = result.data.items;
            }
        }
        catch (err) {
            HandleCathBlok(err);
        }

        try {
            const url = `/Module/GetById`;
            let data = { id: id };
            let result = await SendGetRequest(url, data);
            if (result.isSuccess) {
                app.module = result.data;
                //app.modules = result.data.items;
            }
        }
        catch (err) {
            HandleCathBlok(err);
        }
        CloseInitLoader();
    },
    methods: {
        async UpdateForm() {
            try {
                const url = '/Module/Edit';
                let data = {};

                //let result = await axios.get(url, data);
                data = app.module;
                startLoader();
                let result = await SendPostRequest(url, data);
                closeLoader();
                if (result.isSuccess) {
                    Swal.fire({
                        title: result.message,
                        text: "Modül sayfasına yönlendiriliyorsunuz.",
                        icon: "success",
                        showCancelButton: false,
                        showConfirmButton: true,
                        timer: 2000,
                        willClose: () => {
                            window.location.replace("/Module/Index");
                        }
                    });
                }
            }
            catch (err) {
                HandleCathBlok(err);
            }

        }
    },


}).mount("#app")