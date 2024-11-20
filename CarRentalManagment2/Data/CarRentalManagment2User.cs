using Microsoft.AspNetCore.Identity;

namespace CarRentalManagment2.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class CarRentalManagment2User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
