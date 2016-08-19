using Microsoft.AspNet.Identity.Owin;
using MixUp.Infrastructure;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MixUp.WebApi.Controllers
{
    public class AdminController : ApiController
    {
        private MixUpUserManager UserManager
        {
            get
            {
               return Request.GetOwinContext().GetUserManager<MixUpUserManager>();
            }
        }
        public void Get()
        {
            var a = UserManager;
        }
    }
}
