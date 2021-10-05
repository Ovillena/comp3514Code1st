using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace code1st.Models
{
    public class Team
    {
        [Key]
        public string TeamName { get; set; }
        public string City { get; set; }
        public IEnumerable<Player> PlayerId { get; set; }
    }
}