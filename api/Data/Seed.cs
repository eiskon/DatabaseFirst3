using System.Collections.Generic;
using System.Linq;
using api.Model;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace DatingApp.API.Data
{
    public class Seed
    {
        public static void SeedUsers(UserManager<User> userManager, RoleManager<Role> roleManager)
        {
            if (!userManager.Users.Any())
            {
                var userData = System.IO.File.ReadAllText("Data/UserSeedData.json");
                var users = JsonConvert.DeserializeObject<List<User>>(userData);

                // create some roles

                var roles = new List<Role>
                {
                    new Role {Name = "Admin"},
                    new Role {Name = "Employee"},
                    new Role {Name = "HumanResource"},
                    new Role {Name = "Order"}
                };
                
                // foreach (var role in roles)
                // {
                //     roleManager.CreateAsync(role).Wait(1000);
                // }

                // foreach (var user in users)
                // {
                //     userManager.CreateAsync(user, "password").Wait();
                //     userManager.AddToRoleAsync(user, "Employee");
                // }

                //create admin user
                var adminUser = new User
                {
                    UserName = "Admin"
                };

                var result = userManager.CreateAsync(adminUser, "password").Result;

                // if (result.Succeeded)
                // {
                //     var admin = userManager.FindByNameAsync("Admin").Result;
                //     userManager.AddToRolesAsync(admin, new[] {"Admin", "Employee", "HumanResource", "Order"});
                // }
            }
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}