using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using MixUp.DataAccess;
using MixUp.Entities;

namespace MixUp.Infrastructure
{
    public class MixUpUserManager : UserManager<MixUpUser>
    {
        public MixUpUserManager(IUserStore<MixUpUser> store) : base(store)
        {
        }
        public static MixUpUserManager Create(IdentityFactoryOptions<MixUpUserManager> options, IOwinContext context)
        {
            MixUpDbContext db = context.Get<MixUpDbContext>();

            MixUpUserManager manager = new MixUpUserManager(new UserStore<MixUpUser>(db));

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true
            };

            manager.UserValidator = new UserValidator<MixUpUser>(manager)
            {
                AllowOnlyAlphanumericUserNames = true,
                RequireUniqueEmail = true
            };

            return manager;
        }
    }
}
