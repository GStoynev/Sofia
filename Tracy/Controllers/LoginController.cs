using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tracy.Controllers
{
    public class LoginController : ApiController
    {
        [HttpGet, ActionName("KajiZdrasti")]
        public HttpResponseMessage SayHi()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "SUCCESS");
        }
    }
}
