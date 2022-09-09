using System.ComponentModel.DataAnnotations;

namespace leaderboard_league_app.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        // user ID from AspNetUser table.
        public string? OwnerID { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public virtual List<Attempt> Attempt { get; set; }  
        public ContactStatus Status { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
