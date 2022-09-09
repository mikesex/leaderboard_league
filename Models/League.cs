using System.ComponentModel.DataAnnotations;

namespace leaderboard_league_app.Models
{
    public class League
    {
        public Guid LeagueID { get; set; }
        // user ID from AspNetUser table.
        public string? OwnerID { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }
}
