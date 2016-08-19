﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using MixUp.Infrastructure;
using System.Collections;
using System.Collections.Generic;
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
        public IEnumerable<IdentityUser> Get()
        {
            return UserManager.Users;
        }
    }
}
