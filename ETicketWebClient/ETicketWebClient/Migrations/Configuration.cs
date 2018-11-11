namespace ETicketWebClient.Migrations
{
    using ETicketWebClient.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ETicketWebClient.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ETicketWebClient.Models.ApplicationDbContext context)
        {
            if(!context.Users.Any(u => u.UserName == "darwish.mammo@gmail.com"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);

                var userStore = new UserStore<ApplicationUser>(context);
                var userManager = new UserManager<ApplicationUser>(userStore);

                var user = new ApplicationUser { FullName = "Darwish", Email = "darwish.mammo@gmail.com", UserName = "darwish.mammo@gmail.com"};

                userManager.Create(user, "Test.1234");
                roleManager.Create(new IdentityRole { Name = "admin" });
                roleManager.Create(new IdentityRole { Name = "customer" });
                userManager.AddToRole(user.Id, "admin");
            }
        }
    }
}
