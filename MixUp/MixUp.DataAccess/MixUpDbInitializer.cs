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
            base.Seed(context);
        }
    }
}
