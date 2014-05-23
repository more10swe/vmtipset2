using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class Match
    {
        [Key]
        public int MatchId { get; set; }
        public IEnumerable<Teams> HomeTeam { get; set; }
        public IEnumerable<Teams> AwayTeam { get; set; }
        public DateTime KickOff { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
}