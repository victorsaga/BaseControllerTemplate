using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseControllerTemplate.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        [Route("Index")]
        [HttpGet]
        public string Index()
        {
            return GetValue();
        }

        public abstract string GetValue();        
    }
}
