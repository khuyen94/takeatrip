using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TakeATrip.Common;
using TakeATrip.Entities.IdentityDB;

namespace TakeATrip.Web
{
    public partial class Startup
    {
        private async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();
            
            var SupperAdminUser = Configuration.GetSection("DefaultIdentity").GetSection("SupperAdminUser").Value.Split(';');

            foreach (var role in Roles.ListRole)
            {
                string roleName = role.Trim();
                IdentityResult roleResult;
                //Adding Role
                var roleCheck = await RoleManager.RoleExistsAsync(roleName);
                if (!roleCheck)
                {
                    //create the roles and seed them to the database
                    roleResult = await RoleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            foreach (var u in SupperAdminUser)
            {
                string userName = u.Trim();
                //Assign Admin role to the main User here we have given our newly registered 
                //login id for Admin management
                ApplicationUser user = await UserManager.FindByEmailAsync(userName);
                var User = new ApplicationUser();
                await UserManager.AddToRoleAsync(user, Roles.SupperAdmin);
            }
        }
    }
}
