const app = Vue.createApp({
    data() {
        return {
            module: {
                name: "",
                controller: "",
                action: "",
                address: "",
                icon: "",
                type: "",
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
        CloseInitLoader();
    },
    methods: {
        async AddForm() {
            try {
                const url = '/Module/Create';
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