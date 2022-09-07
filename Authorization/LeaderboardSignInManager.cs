using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace leaderboard_league_app.Authorization
{
    public class LeaderboardSignInManager : SignInManager<IdentityUser>
    {
        public LeaderboardSignInManager(Microsoft.AspNetCore.Identity.UserManager<Microsoft.AspNetCore.Identity.IdentityUser> userManager, Microsoft.AspNetCore.Http.IHttpContextAccessor contextAccessor, Microsoft.AspNetCore.Identity.IUserClaimsPrincipalFactory<Microsoft.AspNetCore.Identity.IdentityUser> claimsFactory, Microsoft.Extensions.Options.IOptions<Microsoft.AspNetCore.Identity.IdentityOptions> optionsAccessor, ILogger<SignInManager<IdentityUser>> logger, IAuthenticationSchemeProvider schemes, IUserConfirmation<IdentityUser> confirmation)
            : base(userManager,
                   contextAccessor,
                   claimsFactory,
                   optionsAccessor,
                   logger,
                   schemes,
                   confirmation
                   )
        {
        }

        public override async Task<SignInResult> PasswordSignInAsync(string userName, string password,
            bool isPersistent, bool lockoutOnFailure)
        {
            var user = await UserManager.FindByEmailAsync(userName);
            if (user == null)
            {
                user = await UserManager.FindByNameAsync(userName);
                var y = await UserManager.FindByIdAsync(userName);
                if (user == null)
                {
                    return SignInResult.Failed;
                }
            }

            return await PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
        }
    }
}
