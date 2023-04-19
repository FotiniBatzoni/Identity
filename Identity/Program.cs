using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;


namespace Identity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var userStore = new UserStore<IdentityUser>();
            var userManager = new UserManager<IdentityUser>(userStore);

            var creationResult = userManager.Create(new IdentityUser
                ("scott@test.com"), "Password123!");
            Console.WriteLine($"Created: {0}", creationResult.Succeeded);
            Console.ReadLine();
        }
    }
}
