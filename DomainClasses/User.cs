using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainClasses
{
    public class User
    {
        // Primitive properties (enligt plural)
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        // Navigation properties (enligt plural)
        // virtual gör att EF kan tillämpa "Lazy loading"
        public virtual ICollection<Bet> Bets { get; set; }
    }
}