using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class DataController : ApiController
    {
        [AllowAnonymous]
        [HttpGet]
        [Route("api/data/forall")]
        public IHttpActionResult Get()
        {
            return Ok("Server time : " + DateTime.Now.ToString());
        }

        [Authorize]
        [HttpGet]
        [Route("api/data/authenticate")]
        public IHttpActionResult GetForAuth()
        {
            return Ok("You are authed\n" + User.Identity.Name);
        }

        [Authorize(Roles ="admin")]
        [HttpGet, HttpOptions]
        [Route("api/data/authorize")]
        public IHttpActionResult GetForAdmin()
        {
            return Ok("You are admin\n" + User.Identity.Name);
        }

    }
}
