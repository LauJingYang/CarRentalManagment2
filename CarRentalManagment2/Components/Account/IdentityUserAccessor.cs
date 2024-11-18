using CarRentalManagment2.Data;
using Microsoft.AspNetCore.Identity;

namespace CarRentalManagment2.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<CarRentalManagment2User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<CarRentalManagment2User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
