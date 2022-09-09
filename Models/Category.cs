using System.ComponentModel.DataAnnotations;

namespace leaderboard_league_app.Models
{
    public class Category
    {
        public Guid CategoryID { get; set; }
        // user ID from AspNetUser table.
        public string Name { get; set; }
        public Game Game { get; set; }
    }
}
