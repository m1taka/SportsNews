using SportsNews.Data;
using System;
using System.Linq;
using System.Security.Principal;
using System.Web.Mvc;
using System.Web.Mvc.Filters;
using System.Web.Routing;

namespace SportsNews.App.Controllers
{
    public abstract class BaseController : Controller
    {
        private ISportsNewsData context;

        public BaseController()
        {
            this.context = new SportsNewsData();
        }

        public BaseController(ISportsNewsData context)
        {
            this.context = context;
        }

        protected ISportsNewsData Context
        {
            get
            {
                return this.context;
            }
        }  
    }
}