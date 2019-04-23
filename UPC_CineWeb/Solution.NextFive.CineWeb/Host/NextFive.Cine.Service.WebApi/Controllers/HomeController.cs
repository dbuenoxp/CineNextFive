using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace NextFive.Cine.Service.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
            : this(GlobalConfiguration.Configuration)
        {

        }

        public HomeController(HttpConfiguration config)
        {
            this.Configuration = config;
        }

        public HttpConfiguration Configuration { get; private set; }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page Service";

            var model = Configuration.Services.GetApiExplorer().ApiDescriptions;

            return View(model);
        }
    }
}
