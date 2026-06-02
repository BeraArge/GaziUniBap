const vm = Vue.createApp({
    data() {
        return {
            notifications: [],
            search: "",
            form: {
                message: ""
            }
        }
    },

    computed: {
        filteredNotifications() {
            const searchText = this.search.toLowerCase();

            return this.notifications.filter(x =>
                (x.message || "").toLowerCase().includes(searchText)
            );
        }
    },

    async mounted() {
        await this.getAll();
    },

    methods: {
        async getAll() {
            try {
                const response = await fetch("/Notification/NotificationGetAll");
                const result = await response.json();

                if (result.success || result.isSuccess) {
                    this.notifications = result.data || [];
                } else {
                    this.notifications = [];
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: 'error',
                    title: 'Hata!',
                    text: 'Bildirim listesi alınırken hata oluştu.',
                    confirmButtonColor: '#087c8f'
                });
            }
        },

        async sendNotification() {
            if (!this.form.message || this.form.message.trim() === "") {
                Swal.fire({
                    icon: 'warning',
                    title: 'Uyarı',
                    text: 'Bildirim mesajı zorunludur.',
                    confirmButtonColor: '#087c8f'
                });

                return;
            }

            const confirmResult = await Swal.fire({
                title: 'Bildirim gönderilsin mi?',
                text: 'Bu bildirim kullanıcılara gönderilecektir.',
                icon: 'question',
                showCancelButton: true,
                confirmButtonColor: '#087c8f',
                cancelButtonColor: '#6c757d',
                confirmButtonText: 'Evet, gönder',
                cancelButtonText: 'Vazgeç'
            });

            if (!confirmResult.isConfirmed) {
                return;
            }

            try {
                const response = await fetch("/Notification/NotificationSend", {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(this.form)
                });

                const result = await response.json();

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
                    text: 'Bildirim gönderilirken hata oluştu.',
                    confirmButtonColor: '#087c8f'
                });
            }
        },

        clearForm() {
            this.form = {
                message: ""
            };
        },

        formatDate(date) {
            if (!date) return "-";

            return new Date(date).toLocaleString("tr-TR");
        }
    },
}).mount("#app");