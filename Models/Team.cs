using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst.Models
{
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public string City { get; set; }

        public List<Player> Players { get; set; }
    }
}