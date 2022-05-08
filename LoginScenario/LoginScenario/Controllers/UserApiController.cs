using LoginScenario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LoginScenario.Controllers
{
    public class UserApiController : ApiController
    {
        LoginScenarioEntities LoginDB = new LoginScenarioEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetDetails(int id)
        {
            var UserDetails = LoginDB.Registers.Where(usermodel => usermodel.Id == id).FirstOrDefault();
            return Ok(UserDetails);
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateAccount(Register CreateRegister)
        {
            LoginDB.Registers.Add(CreateRegister);
            LoginDB.SaveChanges();
            return Ok();
        }

        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateAccount(Register UpdateRegister)
        {
            LoginDB.Entry(UpdateRegister).State = System.Data.Entity.EntityState.Modified;
            LoginDB.SaveChanges();

            return Ok();
        }
    }
}
