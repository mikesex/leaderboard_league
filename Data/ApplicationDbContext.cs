using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using leaderboard_league_app.Models;
namespace leaderboard_league_app.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
    public DbSet<Contact> Contact { get; set; }
    public DbSet<Category> Category { get; set; }
    public DbSet<Game> Game { get; set; }
    public DbSet<League> League { get; set; }
    public DbSet<Attempt> Attempt { get; set; }


}
