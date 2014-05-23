using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class Bet
    {
        [Key]
        public int MatchId { get; set; }
        [Key]
        public int UserId { get; set; }
        public int? HomeGoals { get; set; }
        public int? AwayGoals { get; set; }
    }
}