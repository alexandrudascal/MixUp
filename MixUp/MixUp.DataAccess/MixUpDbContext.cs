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
    public class MixUpDbContext : IdentityDbContext<User>
    {
        public MixUpDbContext()
            :base("MixUpContext")
        {
        }

        static MixUpDbContext()
        {
            Database.SetInitializer(new MixUpDbInitializer());
        }
        public static MixUpDbContext Create()
        {
            return new MixUpDbContext();
        }
    }
}
