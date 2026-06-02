const app = Vue.createApp({
    data() {
        return {
            userId: null,
            phone: null,
            symptoms: [],
            bkiValues: [],
            exerciseTimes: []
        };
    },

    mounted() {
        this.userId = document.getElementById("userId").value;
        this.getUserDetail();
    },

    methods: {
        getUserDetail() {
            axios.get(`/User/GetUserHealthDetail?id=${this.userId}`)
                .then(response => {
                    const result = response.data;

                    if (result.success || result.isSuccess) {
                        const data = result.data;

                        this.phone = data.fullName +"-"+ data.phone || "-";
                        this.symptoms = data.symptoms || [];
                        this.bkiValues = data.bkiValues || [];
                        this.exerciseTimes = data.exerciseTimes || [];
                    } else {
                        this.phone = "-";
                        this.symptoms = [];
                        this.bkiValues = [];
                        this.exerciseTimes = [];
                    }
                })
                .catch(error => {
                    console.error("Kullanıcı detay bilgileri alınamadı:", error);
                });
        },

        formatDate(date) {
            if (!date) return "-";

            return new Date(date).toLocaleDateString("tr-TR", {
                day: "2-digit",
                month: "2-digit",
                year: "numeric",
                hour: "2-digit",
                minute: "2-digit"
            });
        },

        formatSecond(second) {
            if (!second && second !== 0) return "-";

            const minutes = Math.floor(second / 60);
            const remainingSeconds = second % 60;

            if (minutes === 0) {
                return `${remainingSeconds} sn`;
            }

            return `${minutes} dk ${remainingSeconds} sn`;
        }
    }
});

app.mount("#app");