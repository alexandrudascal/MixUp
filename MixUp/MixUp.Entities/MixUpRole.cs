using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixUp.Entities
{
    public class MixUpRole : IdentityRole
    {
        public MixUpRole() : base() { }
        public MixUpRole(string name) : base(name) { }
    }
}
