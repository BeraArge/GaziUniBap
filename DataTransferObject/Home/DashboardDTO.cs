using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.Home
{
    public class DashboardDTO
    {
        public int TotalStudentCount { get; set; }
        public int SimulationCompletedCount { get; set; }
        public int AnalysisCompletedCount { get; set; }

        public int TotalAnswerCount { get; set; }
        public int CorrectAnswerCount { get; set; }
        public int WrongAnswerCount { get; set; }

        public int TotalScore { get; set; }
        public double AverageScore { get; set; }

        public double SimulationCompletedRate { get; set; }
        public double AnalysisCompletedRate { get; set; }
        public double SuccessRate { get; set; }

        public List<DashboardTopUserDTO> TopUsers { get; set; } = new();
        public List<DashboardScoreDistributionDTO> ScoreDistribution { get; set; } = new();
        public List<DashboardRecentActivityDTO> RecentActivities { get; set; } = new();
    }
    public class DashboardTopUserDTO
    {
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string? OgrenciNo { get; set; }
        public int TotalScore { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }
        public double SuccessRate { get; set; }
    }
    public class DashboardScoreDistributionDTO
    {
        public string Label { get; set; }
        public int Count { get; set; }
    }
    public class DashboardRecentActivityDTO
    {
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public string ActivityType { get; set; }
        public string Description { get; set; }
        public DateTime? Date { get; set; }
    }
}
