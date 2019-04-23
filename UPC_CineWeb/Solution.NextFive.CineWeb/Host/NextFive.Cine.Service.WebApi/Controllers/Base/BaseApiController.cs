using NextFive.Cine.Common.JSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace NextFive.Cine.Service.WebApi.Controllers.Base
{
    public class BaseApiController : ApiController
    {
        public BaseApiController()
        {
            this.JsonManager = new JsonManager();
        }

        public IJsonManager JsonManager { get; private set; }
    }
}