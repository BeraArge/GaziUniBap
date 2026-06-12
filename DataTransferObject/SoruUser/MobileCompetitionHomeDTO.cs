using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.SoruUser
{
    public class MobileCompetitionHomeDTO
    {
        public int UserId { get; set; }
        public string? FullName { get; set; }

        public int TotalScore { get; set; }
        public int Rank { get; set; }
        public int TotalParticipantCount { get; set; }

        public int TotalAnswerCount { get; set; }
        public int CorrectCount { get; set; }
        public int WrongCount { get; set; }

        public double SuccessRate { get; set; }

        public string StatusMessage { get; set; }

        public List<MobileLeaderboardUserDTO> Leaderboard { get; set; } = new();
        public List<MobileLeaderboardUserDTO> NearbyUsers { get; set; } = new();
    }
    public class MobileLeaderboardUserDTO
    {
        public int UserId { get; set; }
        public string? FullName { get; set; }
        public int TotalScore { get; set; }
        public int Rank { get; set; }
        public bool IsCurrentUser { get; set; }
    }
}
