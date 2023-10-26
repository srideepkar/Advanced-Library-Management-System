using Advance_Library_Management_Application.Areas.Identity.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace Advance_Library_Management_Application.Areas.Identity.Data
{
    public static class DbSeeder
    {
        /*THIS IS THE DBSEEDER FOR ROLES ASSIGNMENT*/
        public static async Task SeedRolesAndAdminAsync(IServiceProvider service)
        {
            var userManager = service.GetService<UserManager<LibraryApplicationUser>>();
            var roleManager = service.GetService<RoleManager<IdentityRole>>();
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Manager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Member.ToString()));

            /*var user = new LibraryApplicationUser
            {
                FirstName = "Admin",
                LastName = "admin",
                Age = 30,
                Address = "356, Lindsey Street",
                Email = "admin.admin@alms.com",
            };
            var userInDb = await userManager.FindByEmailAsync(user.Email);
            if (userInDb == null)
            {
                await userManager.CreateAsync(user, "Admin@123");
                await userManager.AddToRoleAsync(user, Roles.Admin.ToString());
            }*/
        }
    }
}
