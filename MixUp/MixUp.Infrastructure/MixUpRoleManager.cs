using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using MixUp.DataAccess;
using MixUp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixUp.Infrastructure
{
    public class MixUpRoleManager : RoleManager<MixUpRole>, IDisposable
    {
        public MixUpRoleManager(RoleStore<MixUpRole> store)
        : base(store)
        {
        }

        public static MixUpRoleManager Create(IdentityFactoryOptions<MixUpRoleManager> options, IOwinContext context)
        {
            return new MixUpRoleManager(new RoleStore<MixUpRole>(context.Get<MixUpDbContext>()));
        }
    }

}
