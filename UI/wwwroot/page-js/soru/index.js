const vm = Vue.createApp({
    data() {
        return {
            questions: [],
            isUpdate: false,
            search: "",
            icerikTuru: "videoSoru",
            form: this.emptyForm(),
            formAccordionOpen: false,
            currentPage: 1,
            pageSize: 5,
            videoTranscript: "",
            onBilgilendirmeEditor: null,
            onBilgilendirme: {
                id: 0,
                onBilgilendirmeMetni: ""
            }
        };
    },

    computed: {
        filteredQuestions() {
            const searchText = this.search.toLowerCase();

            return this.questions.filter(x =>
                (x.soruMetni || "").toLowerCase().includes(searchText) ||
                (x.hedef || "").toLowerCase().includes(searchText) ||
                (x.olcekMaddesi || "").toLowerCase().includes(searchText)
            );
        },

        totalPages() {
            return Math.ceil(this.filteredQuestions.length / this.pageSize) || 1;
        },

        pagedQuestions() {
            const start = (this.currentPage - 1) * this.pageSize;
            return this.filteredQuestions.slice(start, start + this.pageSize);
        }
    },

    watch: {
        search() {
            this.currentPage = 1;
        }
    },

    async mounted() {
        await this.getOnBilgilendirme();

        this.$nextTick(() => {
            setTimeout(() => {
                this.initCKEditor();
            }, 300);
        });

        await this.getAll();
    },

    methods: {
        icerikTuruDegistir(tur) {
            this.icerikTuru = tur;

            // Alanlardaki verileri burada silmiyoruz.
            // Kullanıcı yanlışlıkla tür değiştirirse bilgileri kaybolmasın.
        },
        initCKEditor() {
            if (typeof CKEDITOR === "undefined") {
                console.error("CKEDITOR yüklenmemiş.");
                return;
            }

            const el = document.getElementById("editor1");

            if (!el) {
                console.error("editor1 textarea bulunamadı.");
                return;
            }

            if (CKEDITOR.instances.editor1) {
                CKEDITOR.instances.editor1.destroy(true);
            }

            CKEDITOR.replace("editor1", {
                height: 350,
                removePlugins: "easyimage,cloudservices,exportpdf",
                toolbar: [
                    { name: "document", items: ["Source", "Preview"] },
                    { name: "basicstyles", items: ["Bold", "Italic", "Underline", "-", "RemoveFormat"] },
                    { name: "paragraph", items: ["NumberedList", "BulletedList", "-", "JustifyLeft", "JustifyCenter", "JustifyRight"] },
                    { name: "links", items: ["Link", "Unlink"] },
                    { name: "insert", items: ["Table", "HorizontalRule", "SpecialChar"] },
                    { name: "styles", items: ["Format", "Font", "FontSize"] },
                    { name: "colors", items: ["TextColor", "BGColor"] },
                    { name: "tools", items: ["Maximize"] }
                ]
            });

            CKEDITOR.instances.editor1.on("instanceReady", async () => {
                await this.getOnBilgilendirme();
            });

            CKEDITOR.instances.editor1.on("change", () => {
                this.onBilgilendirme.onBilgilendirmeMetni =
                    CKEDITOR.instances.editor1.getData();
            });
        },

        async getOnBilgilendirme() {
            try {
                const response = await fetch("/OnBilgilendirme/GetOnBilgilendirme");
                const result = await response.json();

                if (result.success || result.isSuccess) {
                    this.onBilgilendirme = result.data || {
                        id: 0,
                        onBilgilendirmeMetni: ""
                    };

                    const html = this.onBilgilendirme.onBilgilendirmeMetni || "";

                    if (CKEDITOR.instances.editor1) {
                        CKEDITOR.instances.editor1.setData(html);
                    }
                }
            } catch (error) {
                console.error("Ön bilgilendirme getirilemedi:", error);
            }
        },

        async saveOnBilgilendirme() {
            try {
                const editorData = CKEDITOR.instances.editor1
                    ? CKEDITOR.instances.editor1.getData()
                    : "";

                this.onBilgilendirme.onBilgilendirmeMetni = editorData;

                const response = await fetch("/OnBilgilendirme/SaveOnBilgilendirme", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(this.onBilgilendirme)
                });

                const result = await response.json();

                Swal.fire({
                    icon: (result.success || result.isSuccess) ? "success" : "error",
                    title: (result.success || result.isSuccess) ? "Başarılı" : "Hata",
                    text: result.message,
                    confirmButtonColor: "#087c8f"
                });

                if (result.success || result.isSuccess) {
                    this.onBilgilendirme = result.data;
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Ön bilgilendirme kaydedilirken hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },

        changePage(page) {
            if (page < 1 || page > this.totalPages) {
                return;
            }

            this.currentPage = page;
        },

        emptyForm() {
            return {
                id: 0,
                videoPath: "",
                videoFile: null,
                hedef: "",
                olcekMaddesi: "",
                videoTranscript: "",
                soruMetni: "",
                order: null,
                beklemeSuresi: 0,
                acikUcluMu: false,
                bildirimMetni: "",
                cevaplar: [
                    { key: "A", value: "", explanation: "" },
                    { key: "B", value: "", explanation: "" },
                    { key: "C", value: "", explanation: "" },
                    { key: "D", value: "", explanation: "" }
                ],
                dogruCevap: {
                    key: "",
                    explanation: ""
                }
            };
        },

        async getAll() {
            try {
                const response = await fetch("/Soru/SoruGetAll");
                const result = await response.json();

                if (result.success || result.isSuccess) {
                    this.questions = result.data || [];
                } else {
                    this.questions = [];
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Listeleme sırasında hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },

        addAnswer() {
            const letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (this.form.cevaplar.length >= letters.length) {
                this.warning("En fazla 26 cevap şıkkı eklenebilir.");
                return;
            }

            const nextKey = letters[this.form.cevaplar.length];

            this.form.cevaplar.push({
                key: nextKey,
                value: "",
                explanation: ""
            });
        },

        removeAnswer(index) {
            if (this.form.cevaplar.length <= 2) {
                this.warning("En az 2 cevap şıkkı olmalıdır.");
                return;
            }

            const selectedAnswer = this.form.cevaplar.find(
                x => x.key === this.form.dogruCevap.key
            );

            const removedAnswer = this.form.cevaplar[index];

            this.form.cevaplar.splice(index, 1);

            this.reorderAnswerKeys();

            if (removedAnswer === selectedAnswer) {
                this.form.dogruCevap.key = "";
            } else if (selectedAnswer) {
                const newSelected = this.form.cevaplar.find(
                    x => x === selectedAnswer
                );

                this.form.dogruCevap.key = newSelected
                    ? newSelected.key
                    : "";
            }
        },

        reorderAnswerKeys() {
            const letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            this.form.cevaplar.forEach((answer, index) => {
                answer.key = letters[index];
            });
        },




        validateForm() {

            const videoGerekli =
                this.icerikTuru === "video" ||
                this.icerikTuru === "videoSoru";

            const soruGerekli =
                this.icerikTuru === "soru" ||
                this.icerikTuru === "videoSoru";

            // Video gereken içeriklerde video kontrolü
            if (videoGerekli) {

                if (!this.form.videoFile && !this.form.videoPath?.trim()) {
                    this.warning("Lütfen video dosyası seçiniz.");
                    return false;
                }
            }

            // Sadece video ise soru validasyonu uygulanmaz
            if (!soruGerekli) {
                return true;
            }

            if (!this.form.soruMetni?.trim()) {
                this.warning("Soru metni zorunludur.");
                return false;
            }
            if (this.form.acikUcluMu) {
                return true;
            }
            const cevaplar = this.form.cevaplar.filter(
                x => !!x.value?.trim()
            );

            if (cevaplar.length < 2) {
                this.warning("En az 2 cevap şıkkı girilmelidir.");
                return false;
            }

            if (cevaplar.length !== this.form.cevaplar.length) {
                this.warning("Tüm cevap şıklarını doldurunuz.");
                return false;
            }

            if (!this.form.dogruCevap.key) {
                this.warning("Doğru cevap seçilmelidir.");
                return false;
            }

            const dogruCevap = cevaplar.find(
                x => x.key === this.form.dogruCevap.key
            );

            if (!dogruCevap) {
                this.warning("Geçerli bir doğru cevap seçiniz.");
                return false;
            }


            for (const answer of cevaplar) {

                if (answer.key !== this.form.dogruCevap.key &&
                    !answer.explanation?.trim()) {

                    this.warning(
                        `${answer.key} şıkkı için yanlış cevap gerekçesi giriniz.`
                    );

                    return false;
                }
            }

            return true;
        },



        warning(message) {
            Swal.fire({
                icon: "warning",
                title: "Uyarı",
                text: message,
                confirmButtonColor: "#087c8f"
            });
        },

        async save() {
            if (!this.validateForm()) {
                return;
            }

            if (this.isUpdate) {
                await this.update();
            } else {
                await this.add();
            }
        },



        createFormData() {
            const formData = new FormData();

            const videoVar = this.icerikTuru !== "soru";
            const soruVar = this.icerikTuru !== "video";

            formData.append("Id", this.form.id || 0);

            formData.append(
                "VideoPath",
                videoVar ? (this.form.videoPath || "") : ""
            );

            formData.append(
                "VideoTranscript",
                videoVar ? (this.form.videoTranscript || "") : ""
            );

            formData.append("Hedef", soruVar ? (this.form.hedef || "") : "");
            formData.append("OlcekMaddesi", soruVar ? (this.form.olcekMaddesi || "") : "");
            formData.append("SoruMetni", soruVar ? (this.form.soruMetni || "") : "");

            formData.append("BeklemeSuresi", this.form.beklemeSuresi ?? 0);
            formData.append("BildirimMetni", this.form.bildirimMetni || "");
            if (this.form.order != null) {
                formData.append("Order", this.form.order);
            }
            if (soruVar && !this.form.acikUcluMu) {
                this.form.cevaplar.forEach((answer, index) => {
                    formData.append(`Cevaplar[${index}][key]`, answer.key);
                    formData.append(`Cevaplar[${index}][value]`, answer.value);

                    formData.append(
                        `Cevaplar[${index}][explanation]`,
                        answer.key === this.form.dogruCevap.key
                            ? ""
                            : (answer.explanation || "")
                    );
                });
                 
                formData.append("DogruCevap[key]", this.form.dogruCevap.key);
                formData.append("DogruCevap[explanation]", "");
            }
            if (soruVar && this.form.acikUcluMu) {
                formData.append("DogruCevap[key]", "");
                formData.append("DogruCevap[explanation]", "");
            }
            if (videoVar && this.form.videoFile) {
                formData.append("VideoFile", this.form.videoFile);
            }
            console.log(this.form)
            return formData;
        },

        handleVideoFile(event) {
            const file = event.target.files[0];
            this.form.videoFile = file || null;
        },

        async add() {
            try {
                const config = {
                    headers: {
                        "RequestVerificationToken": VerifyToken
                    }
                };
                const url = "/Soru/AddSoru";
                const data = this.createFormData();

                startLoader();
                console.log(data);
                console.log("FormData içeriği:", [...data.entries()]);

                const response = await axios.post(url, data, {
                    headers: {
                        "RequestVerificationToken": VerifyToken
                    }
                });

                const result = response.data;
                Swal.fire({
                    icon: (result.success || result.isSuccess) ? "success" : "error",
                    title: (result.success || result.isSuccess) ? "Başarılı" : "Hata",
                    text: result.message,
                    confirmButtonColor: "#087c8f"
                });

                if (result.success || result.isSuccess) {
                    this.clearForm();
                    await this.getAll();
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Ekleme sırasında hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },

        getFileName(path) {
            if (!path) return "-";
            return path.split("/").pop();
        },

        edit(item) {
            this.isUpdate = true;

            let cevaplar = item.cevaplar || [];

            if (typeof cevaplar === "string") {
                cevaplar = JSON.parse(cevaplar);
            }

            let dogruCevap = item.dogruCevap || {
                key: "",
                explanation: ""
            };

            if (typeof dogruCevap === "string") {
                dogruCevap = JSON.parse(dogruCevap);
            }

            this.form = {
                id: item.id,
                videoFile: null,
                videoPath: item.videoPath || "",
                hedef: item.hedef || "",
                olcekMaddesi: item.olcekMaddesi || "",
                soruMetni: item.soruMetni || "",
                videoTranscript: item.videoTranscript || "",
                beklemeSuresi: item.beklemeSuresi ?? 0,
                bildirimMetni: item.bildirimMetni ?? "",
                order: item.order ?? null,
                cevaplar: cevaplar.length > 0
                    ? cevaplar.map((x, index) => ({
                        key: "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[index],
                        value: x.value || x.Value || "",
                        explanation: x.explanation || x.Explanation || ""
                    }))
                    : [
                        { key: "A", value: "", explanation: "" },
                        { key: "B", value: "", explanation: "" }
                    ],
                acikUcluMu: !!item.soruMetni?.trim() &&
                    cevaplar.length === 0,
                dogruCevap: {
                    key: dogruCevap.key || dogruCevap.Key || "",
                    explanation: dogruCevap.explanation ||
                        dogruCevap.Explanation || ""
                }
            };
            const videoVar = !!item.videoPath;
            const soruVar = !!item.soruMetni?.trim();

            this.icerikTuru =
                videoVar && soruVar ? "videoSoru" :
                    videoVar ? "video" :
                        "soru";
            this.formAccordionOpen = true;

            this.$nextTick(() => {
                const formArea = document.getElementById("questionFormArea");

                if (formArea) {
                    formArea.scrollIntoView({
                        behavior: "smooth",
                        block: "start"
                    });
                }
            });
        },

        async update() {
            try {
                const config = {
                    headers: {
                        "RequestVerificationToken": VerifyToken
                    }
                };

                const url = "/Soru/UpdateSoru";
                const data = this.createFormData();

                startLoader();

                const result = await SendPostRequest(url, data, config);

                Swal.fire({
                    icon: (result.success || result.isSuccess) ? "success" : "error",
                    title: (result.success || result.isSuccess) ? "Başarılı" : "Hata",
                    text: result.message,
                    confirmButtonColor: "#087c8f"
                });

                if (result.success || result.isSuccess) {
                    this.clearForm();
                    this.formAccordionOpen = false;
                    await this.getAll();
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Güncelleme sırasında hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },


        async deleteItem(id) {
            const confirmResult = await Swal.fire({
                title: "Emin misiniz?",
                text: "Bu soru silinecektir.",
                icon: "warning",
                showCancelButton: true,
                confirmButtonColor: "#d33",
                cancelButtonColor: "#6c757d",
                confirmButtonText: "Evet, sil",
                cancelButtonText: "Vazgeç"
            });

            if (!confirmResult.isConfirmed) {
                return;
            }

            try {
                const result = await SendPostRequest(
                    "/Soru/DeleteSoru",
                    id
                );

                Swal.fire({
                    icon: (result.success || result.isSuccess) ? "success" : "error",
                    title: (result.success || result.isSuccess) ? "Başarılı" : "Hata",
                    text: result.message,
                    confirmButtonColor: "#087c8f"
                });

                if (result.success || result.isSuccess) {
                    await this.getAll();
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Silme sırasında hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },

        clearForm() {
            this.isUpdate = false;
            this.form = this.emptyForm();
            this.formAccordionOpen = false;
        }
    }
}).mount("#app");
