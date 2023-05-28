using Microsoft.AspNetCore.Identity;
using RideMe.Constans;
using RideMe.Data;

namespace RideMe.Models
{
    public static class SeedRules
    {
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            //Seed Roles
            UserManager<ApplicationUser> userManager = service.GetService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Manager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Customer.ToString()));


            //Create Admin user

            var user = new ApplicationUser
            {
                UserName = "admin@admin.com",
                Email = "admin@admin.com",
                FirstName = "Admin",
                LastName = "Admin",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
            };

            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if(userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin123!");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }
        }
    }
}
