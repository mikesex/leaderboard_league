using System.ComponentModel.DataAnnotations;

namespace leaderboard_league_app.Models
{
    public class Game
    {
        public Guid GameID { get; set; }
        // user ID from AspNetUser table.
        public string Name { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
