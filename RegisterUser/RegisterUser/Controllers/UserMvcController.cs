using RegisterUser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RegisterUser.Controllers
{
    public class UserMvcController : Controller
    {
        HttpClient client = new HttpClient();

        // GET: UserMvc
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Register reg)
        {
            client.BaseAddress = new Uri("https://localhost:44372/api/UserApi");
            var response = client.PostAsJsonAsync<Register>("UserApi", reg);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Login");
            }

            return View("Create");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(RegisterUser.Models.Register reg1)
        {
            using(LoginScenarioEntities db = new LoginScenarioEntities())
            {
                var response = db.Registers.Where(x => x.Usename == reg1.Usename && x.Password == reg1.Password).FirstOrDefault();
                 if(response == null)
                {
                    reg1.LoginErrorMessage = "Wrong Username and Password";
                    return View("Login", reg1);
                }
                else
                {
                    Session["Id"] = response.Id;
                    return RedirectToAction("Details","UserMvc");
                }
            }
        }
        public ActionResult Details(int id)
        {
            Register e = null;
            client.BaseAddress = new Uri("https://localhost:44372/api/UserApi");
            var response = client.GetAsync("UserApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Register>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }
        public ActionResult Edit(int id)
        {
            Register e = null;
            client.BaseAddress = new Uri("https://localhost:44372/api/UserApi");
            var response = client.GetAsync("UserApi?id=" + id.ToString());
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Register>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }
        [HttpPost]
        public ActionResult Edit(Register e)
        {
            client.BaseAddress = new Uri("https://localhost:44372/api/UserApi");
            var response = client.PutAsJsonAsync<Register>("UserApi", e);
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Details");
            }

            return View("Edit");
        }
        public ActionResult CountryList()
        {
            IQueryable countries = Country.GetCountries();

            if (HttpContext.Request.IsAjaxRequest())
            {
                return Json(new SelectList(
                            countries,
                            "Ccode",
                            "Cname"), JsonRequestBehavior.AllowGet
                            );
            }

            return View(countries);
        }

        public ActionResult StateList(string CountryCode)
        {
            IQueryable states = State.GetStates().Where(x => x.Ccode == CountryCode);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                                states,
                                "Scode",
                                "Sname"), JsonRequestBehavior.AllowGet
                            );

            return View(states);
        }
        public ActionResult CityList(string scode)
        {
            IQueryable cities = City.GetCities().Where(y =>y.Scode==scode);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList(
                                cities,
                                "Ctcode",
                                "Cityname"), JsonRequestBehavior.AllowGet
                            );

            return View(cities);
        }
       
    }
}