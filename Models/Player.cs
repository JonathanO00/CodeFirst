

using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public string TeamName { get; set; }

        [ForeignKey("TeamName")]
        public Team Team { get; set; }
    }
}