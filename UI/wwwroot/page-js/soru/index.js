const vm = Vue.createApp({
    data() {
        return {
            questions: [],
            isUpdate: false,
            search: "",
            form: this.emptyForm(),
            formAccordionOpen: false,
            currentPage: 1,
            pageSize: 5,
            videoTranscript: "",
        }
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
        await this.getAll();
    },

    methods: {
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
                hedef: "",
                olcekMaddesi: "",
                videoTranscript: "",
                soruMetni: "",
                cevaplar: [
                    { key: "A", value: "" },
                    { key: "B", value: "" },
                    { key: "C", value: "" },
                    { key: "D", value: "" }
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
                    icon: 'error',
                    title: 'Hata!',
                    text: 'Listeleme sırasında hata oluştu.',
                    confirmButtonColor: '#087c8f'
                });
            }
        },

        addAnswer() {
            const letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const nextKey = letters[this.form.cevaplar.length] || "";

            this.form.cevaplar.push({
                key: nextKey,
                value: ""
            });
        },

        removeAnswer(index) {
            this.form.cevaplar.splice(index, 1);
        },

        validateForm() {
            //if (!this.form.videoPath || this.form.videoPath.trim() === "") {
            //    this.warning("Video path zorunludur.");
            //    return false;
            //}

            if (!this.form.soruMetni || this.form.soruMetni.trim() === "") {
                this.warning("Soru metni zorunludur.");
                return false;
            }

            const validAnswers = this.form.cevaplar.filter(x =>
                x.key && x.key.trim() !== "" &&
                x.value && x.value.trim() !== ""
            );

            if (validAnswers.length < 2) {
                this.warning("En az 2 cevap şıkkı girilmelidir.");
                return false;
            }

            if (!this.form.dogruCevap.key) {
                this.warning("Doğru cevap seçilmelidir.");
                return false;
            }

            const selectedAnswerExists = validAnswers.some(x => x.key === this.form.dogruCevap.key);

            if (!selectedAnswerExists) {
                this.warning("Seçilen doğru cevap, cevap şıkları içinde bulunmalıdır.");
                return false;
            }

            return true;
        },

        warning(message) {
            Swal.fire({
                icon: 'warning',
                title: 'Uyarı',
                text: message,
                confirmButtonColor: '#087c8f'
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
            console.log(this.form)
            formData.append("Id", this.form.id || 0);
            formData.append("VideoPath", this.form.videoPath || "");
            formData.append("Hedef", this.form.hedef || "");
            formData.append("OlcekMaddesi", this.form.olcekMaddesi || "");
            formData.append("SoruMetni", this.form.soruMetni || "");
            formData.append("VideoTranscript", this.form.videoTranscript || "");
            this.form.cevaplar.forEach((answer, index) => {
                formData.append(`Cevaplar[${index}][key]`, answer.key || "");
                formData.append(`Cevaplar[${index}][value]`, answer.value || "");
            });

            formData.append("DogruCevap[key]", this.form.dogruCevap.key || "");
            formData.append("DogruCevap[explanation]", this.form.dogruCevap.explanation || "");

            if (this.form.videoFile) {
                formData.append("VideoFile", this.form.videoFile);
            }

            return formData;
        },
        handleVideoFile(event) {
            const file = event.target.files[0];

            this.form.videoFile = file || null;
        },
        removeAnswer(index) {
            if (this.form.cevaplar.length <= 2) {
                this.warning("En az 2 cevap şıkkı olmalıdır.");
                return;
            }

            const removedKey = this.form.cevaplar[index].key;

            this.form.cevaplar.splice(index, 1);

            this.reorderAnswerKeys();

            if (this.form.dogruCevap.key === removedKey) {
                this.form.dogruCevap.key = "";
            }
        },
        reorderAnswerKeys() {
            const letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            this.form.cevaplar = this.form.cevaplar.map((answer, index) => {
                return {
                    key: letters[index],
                    value: answer.value
                };
            });
        },
        async add() {
            try {

                let config = {
                    headers: {
                        'Content-Type': 'multipart/form-data',
                        'RequestVerificationToken': VerifyToken
                    }
                };
                const url = '/Soru/AddSoru'
                var data = this.createFormData();
                startLoader()
                console.log(data)
                let result = await SendPostRequest(url, data, config);
                console.log(result)
                //const result = await response.json();

                Swal.fire({
                    icon: (result.success || result.isSuccess) ? 'success' : 'error',
                    title: (result.success || result.isSuccess) ? 'Başarılı' : 'Hata',
                    text: result.message,
                    confirmButtonColor: '#087c8f'
                });

                if (result.success || result.isSuccess) {
                    this.clearForm();
                    await this.getAll();
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: 'error',
                    title: 'Hata!',
                    text: 'Ekleme sırasında hata oluştu.',
                    confirmButtonColor: '#087c8f'
                });
            }
        },
        getFileName(path) {
            if (!path) return "-";

            return path.split("/").pop();
        },
        edit(item) {
            console.log("edit item:", item);
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
                cevaplar: cevaplar.length > 0
                    ? cevaplar.map((x, index) => ({
                        key: "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[index],
                        value: x.value || x.Value || ""
                    }))
                    : [
                        { key: "A", value: "" },
                        { key: "B", value: "" }
                    ],
                dogruCevap: {
                    key: dogruCevap.key || dogruCevap.Key || "",
                    explanation: dogruCevap.explanation || dogruCevap.Explanation || ""
                }
            };

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
                let config = {
                    headers: {
                        'RequestVerificationToken': VerifyToken
                    }
                };

                const url = '/Soru/UpdateSoru';
                const data = this.createFormData();

                startLoader();

                let result = await SendPostRequest(url, data, config);

                Swal.fire({
                    icon: (result.success || result.isSuccess) ? 'success' : 'error',
                    title: (result.success || result.isSuccess) ? 'Başarılı' : 'Hata',
                    text: result.message,
                    confirmButtonColor: '#087c8f'
                });

                if (result.success || result.isSuccess) {
                    this.clearForm();
                    this.formAccordionOpen = false;
                    await this.getAll();
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: 'error',
                    title: 'Hata!',
                    text: 'Güncelleme sırasında hata oluştu.',
                    confirmButtonColor: '#087c8f'
                });
            }
        },

        async deleteItem(id) {
            const confirmResult = await Swal.fire({
                title: 'Emin misiniz?',
                text: 'Bu soru silinecektir.',
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#d33',
                cancelButtonColor: '#6c757d',
                confirmButtonText: 'Evet, sil',
                cancelButtonText: 'Vazgeç'
            });

            if (!confirmResult.isConfirmed) {
                return;
            }

            try {
                const response = await fetch(`/Soru/Delete?id=${id}`, {
                    method: "POST"
                });

                const result = await response.json();

                Swal.fire({
                    icon: (result.success || result.isSuccess) ? 'success' : 'error',
                    title: (result.success || result.isSuccess) ? 'Başarılı' : 'Hata',
                    text: result.message,
                    confirmButtonColor: '#087c8f'
                });

                if (result.success || result.isSuccess) {
                    await this.getAll();
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: 'error',
                    title: 'Hata!',
                    text: 'Silme sırasında hata oluştu.',
                    confirmButtonColor: '#087c8f'
                });
            }
        },

        clearForm() {
            this.isUpdate = false;
            this.form = this.emptyForm();
            this.formAccordionOpen = false;
        },
    }
}).mount("#app");