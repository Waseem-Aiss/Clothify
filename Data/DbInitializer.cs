using Clothify.Models;
using Microsoft.AspNetCore.Identity;



namespace Clothify.Data
{
    public class DbInitializer
    {
        public static async Task SeedData(IServiceProvider serviceProvider)
        {
            // Resolve the Managers from the Service Provider
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            // 1. Create the Admin Role if it doesn't exist
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                await roleManager.CreateAsync(new IdentityRole("Admin"));
            }

            // 2. Create the Customer Role if it doesn't exist
            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                await roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            // 3. Create the Admin User
            var adminEmail = "admin@fabrics.com";
            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                var user = new ApplicationUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true,
                    
                };

                // Create the user with a secure password
                var result = await userManager.CreateAsync(user, "Admin@123");

                if (result.Succeeded)
                {
                    // Assign the "Admin" role to this new user
                    await userManager.AddToRoleAsync(user, "Admin");
                }
            }
        }



    }
}
