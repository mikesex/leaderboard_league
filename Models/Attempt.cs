using System.ComponentModel.DataAnnotations;

namespace leaderboard_league_app.Models
{
    public class Attempt
    {
        public Guid AttemptID { get; set; }
        // user ID from AspNetUser table.
        public Category Category { get; set; }
        public Contact Contact { get; set; }
        public double Score { get; set; }
        public double? TieBreakerScore  { get; set; }
        public string Link  { get; set; }
        public string Comment { get; set; }
    }
}
