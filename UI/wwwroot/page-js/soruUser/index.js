
const vm = Vue.createApp({
    data() {
        return {
            reports: [],
            search: "",
            openedUserId: null,
            currentPage: 1,
            pageSize: 6,
            openedCozumlemeUserId: null,
        }
    },

    computed: {
        filteredReports() {
            const searchText = this.search.toLowerCase();

            return this.reports.filter(x =>
                (x.userName || "").toLowerCase().includes(searchText)
            );
        },

        pagedReports() {
            const start = (this.currentPage - 1) * this.pageSize;
            return this.filteredReports.slice(start, start + this.pageSize);
        },

        totalPages() {
            return Math.ceil(this.filteredReports.length / this.pageSize) || 1;
        },

        summary() {
            const totalUsers = this.reports.length;
            const totalAnswers = this.reports.reduce((sum, x) => sum + (x.totalQuestion || 0), 0);
            const totalScore = this.reports.reduce((sum, x) => sum + (x.totalScore || 0), 0);

            const averageSuccess = totalUsers === 0
                ? 0
                : Math.round(
                    this.reports.reduce((sum, x) => sum + (x.successRate || 0), 0) / totalUsers
                );

            return {
                totalUsers,
                totalAnswers,
                totalScore,
                averageSuccess
            };
        }
    },

    watch: {
        search() {
            this.currentPage = 1;
            this.openedUserId = null;
        }
    },

    async mounted() {
        await this.getReports();
    },

    methods: {
        toggleCozumleme(userId) {
            this.openedCozumlemeUserId =
                this.openedCozumlemeUserId === userId ? null : userId;
        }, toggleDetail(userId) {
            this.openedUserId = this.openedUserId === userId ? null : userId;
            this.openedCozumlemeUserId = null;
        },
        async getReports() {
            try {
                const response = await fetch("/SoruUser/GetUserAnswerReports");
                const result = await response.json();

                if (result.success || result.isSuccess) {
                    this.reports = result.data || [];
                } else {
                    this.reports = [];
                }

            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Cevap raporları listelenirken hata oluştu.",
                    confirmButtonColor: "#087c8f"
                });
            }
        },

        toggleDetail(userId) {
            this.openedUserId = this.openedUserId === userId ? null : userId;
        },

        changePage(page) {
            if (page < 1 || page > this.totalPages) {
                return;
            }

            this.currentPage = page;
            this.openedUserId = null;
        },

        getInitials(name) {
            if (!name) return "?";

            return name
                .split(" ")
                .filter(x => x)
                .slice(0, 2)
                .map(x => x[0])
                .join("")
                .toUpperCase();
        }
    }
}).mount("#app");