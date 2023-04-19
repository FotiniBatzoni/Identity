using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Security.Claims;

namespace Identity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var username = "scott@test.com";
            var password = "Password123!";

            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            //var creationResult = userManager.Create(new IdentityUser
            //    ("scott@test.com"), "Password123!");
            //Console.WriteLine($"Created: {0}", creationResult.Succeeded);
            //Console.ReadLine();

            var user = userManager.FindByName(username);
            //var claimResult = userManager.AddClaim(user.Id, new Claim("given_name", "Scott"));
            //Console.WriteLine($"Claim: {0}", claimResult.Succeeded);

            var isMatch = userManager.CheckPassword(user, password);
            Console.WriteLine($"Password Mtach {0}", isMatch);
            Console.ReadLine();
        }
    }
}
