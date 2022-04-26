using RegisterUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RegisterUser.Controllers
{
    public class UserApiController : ApiController
    {
        LoginScenarioEntities db = new LoginScenarioEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetDetails(int id)
        {
            var u = db.Registers.Where(model => model.Id == id).FirstOrDefault();
            return Ok(u);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateAccount(Register e)
        {
            db.Registers.Add(e);
            db.SaveChanges();
            return Ok();
        }
        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateAccount(Register e)
        {
            db.Entry(e).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return Ok();
        }
    }
}
