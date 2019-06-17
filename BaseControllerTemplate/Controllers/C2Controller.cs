using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseControllerTemplate.Controllers
{
    [RoutePrefix("cc2")]
    public class C2Controller : BaseApiController
    {
        public override string GetValue()
        {
            return "C2 " + DateTime.Now;
        }
    }
}
