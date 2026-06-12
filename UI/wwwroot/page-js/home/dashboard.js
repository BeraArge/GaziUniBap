const vm = Vue.createApp({
    data() {
        return {
            dashboard: {
                totalStudentCount: 0,
                simulationCompletedCount: 0,
                analysisCompletedCount: 0,
                totalAnswerCount: 0,
                correctAnswerCount: 0,
                wrongAnswerCount: 0,
                totalScore: 0,
                averageScore: 0,
                simulationCompletedRate: 0,
                analysisCompletedRate: 0,
                successRate: 0,
                topUsers: [],
                scoreDistribution: [],
                recentActivities: []
            }
        }
    },

    async mounted() {
        await this.getDashboardData();
    },

    methods: {
        async getDashboardData() {
            try {
                const response = await fetch("/Home/GetDashboardData");
                const result = await response.json();

                if (result.success || result.isSuccess) {
                    this.dashboard = result.data;
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Dashboard verileri alınırken hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },

        getDistributionRate(count) {
            if (!this.dashboard.totalStudentCount || this.dashboard.totalStudentCount === 0) {
                return 0;
            }

            return Math.round((count / this.dashboard.totalStudentCount) * 100);
        },

        formatDate(date) {
            if (!date) return "-";

            return new Date(date).toLocaleString("tr-TR");
        }
    }
}).mount("#app");