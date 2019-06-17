using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseControllerTemplate.Controllers
{
    [RoutePrefix("cc1")]
    public class C1Controller : BaseApiController
    {
        public override string GetValue()
        {
            return "C1 " + DateTime.Now;
        }
    }
}
