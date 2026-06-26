
const vm = Vue.createApp({
    data() {
        return {
            reports: [],
            search: "",
            openedUserId: null,
            openedCozumlemeUserId: null,
            isExcelDownloading: false,
            pagination: {
                page: 0,
                size: 6,
                count: 0,
                pages: 0
            },

            summary: {
                totalUsers: 0,
                totalAnswers: 0,
                totalScore: 0,
                averageSuccess: 0
            }
        }
    },

    computed: {
        pagedReports() {
            return this.reports;
        },

        totalPages() {
            return this.pagination.pages || 1;
        },

        currentPage() {
            return this.pagination.page + 1;
        }
    },

    watch: {
        search() {
            this.applyFilters();
        }
    },

    async mounted() {
        await this.getReports();
    },

    methods: {
        async downloadExcel() {
            this.isExcelDownloading = true;

            try {
                window.location.href = "/SoruUser/UserAnswerReportsExcel";
            } catch (error) {
                console.error(error);

                Swal.fire({
                    icon: "error",
                    title: "Hata!",
                    text: "Excel indirme işlemi başlatılamadı.",
                    confirmButtonColor: "#087c8f"
                });
            } finally {
                setTimeout(() => {
                    this.isExcelDownloading = false;
                }, 1500);
            }
        },
        async getReports() {
            try {
                const params = new URLSearchParams();

                params.append("page", this.pagination.page);
                params.append("size", this.pagination.size);

                if (this.search) {
                    params.append("search", this.search);
                }

                const response = await fetch(`/SoruUser/GetUserAnswerReports?${params.toString()}`);
                const result = await response.json();

                if (result.success || result.isSuccess) {
                    const data = result.data || {};

                    this.reports = data.items || data.Items || [];

                    const first = this.reports.length > 0
                        ? this.reports[0]
                        : null;

                    this.summary = {
                        totalUsers: first?.summaryTotalUsers || 0,
                        totalAnswers: first?.summaryTotalAnswers || 0,
                        averageScore: first?.summaryAverageScore || 0,
                        averageSuccess: first?.summaryAverageSuccess || 0
                    };

                    this.pagination.count = data.count ?? data.Count ?? 0;
                    this.pagination.pages = data.pages ?? data.Pages ?? 1;
                    this.pagination.page = data.index ?? data.Index ?? 0;
                    this.pagination.size = data.size ?? data.Size ?? 6;
                } else {
                    this.reports = [];
                    this.pagination.pages = 1;
                    this.summary = {
                        totalUsers: 0,
                        totalAnswers: 0,
                        totalScore: 0,
                        averageSuccess: 0
                    };
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
        async applyFilters() {
            this.pagination.page = 0;
            this.openedUserId = null;
            this.openedCozumlemeUserId = null;
            await this.getReports();
        },

        toggleDetail(userId) {
            this.openedUserId = this.openedUserId === userId ? null : userId;
            this.openedCozumlemeUserId = null;
        },

        toggleCozumleme(userId) {
            this.openedCozumlemeUserId =
                this.openedCozumlemeUserId === userId ? null : userId;
        },

        changePage(page) {
            const pageIndex = page - 1;

            if (pageIndex < 0 || pageIndex >= this.pagination.pages) {
                return;
            }

            this.pagination.page = pageIndex;
            this.openedUserId = null;
            this.openedCozumlemeUserId = null;
            this.getReports();
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
        },

        calculateSummaryFromReports(data) {
            const totalUsers = data.length;
            const totalAnswers = data.reduce((sum, x) => sum + (x.totalQuestion || 0), 0);
            const totalScore = data.reduce((sum, x) => sum + (x.totalScore || 0), 0);

            const averageSuccess = totalUsers === 0
                ? 0
                : Math.round(
                    data.reduce((sum, x) => sum + (x.successRate || 0), 0) / totalUsers
                );

            this.summary = {
                totalUsers,
                totalAnswers,
                totalScore,
                averageSuccess
            };
        },

        createSummaryFromPage() {
            const totalUsers = this.pagination.count;
            const totalAnswers = this.reports.reduce((sum, x) => sum + (x.totalQuestion || 0), 0);
            const totalScore = this.reports.reduce((sum, x) => sum + (x.totalScore || 0), 0);

            const averageSuccess = this.reports.length === 0
                ? 0
                : Math.round(
                    this.reports.reduce((sum, x) => sum + (x.successRate || 0), 0) / this.reports.length
                );

            return {
                totalUsers,
                totalAnswers,
                totalScore,
                averageSuccess
            };
        }
    }
}).mount("#app");