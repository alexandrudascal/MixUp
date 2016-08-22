using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MixUp.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixUp.DataAccess
{
    class MixUpDbInitializer: DropCreateDatabaseIfModelChanges<MixUpDbContext>
    {
        protected override void Seed(MixUpDbContext context)
        {
            var roles = new List<MixUpRole>
            {
                new MixUpRole() {Name = UserRoles.Admin.ToString() },
                new MixUpRole() {Name = UserRoles.User.ToString() }
            };

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            roles.ForEach(r => roleManager.Create(r));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}