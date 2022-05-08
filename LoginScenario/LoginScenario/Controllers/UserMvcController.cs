using LoginScenario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace LoginScenario.Controllers
{
    public class UserMvcController : Controller
    {
        // GET: UserMvc

        HttpClient client = new HttpClient();
        
         public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Register CreateView)
        {
            client.BaseAddress = new Uri("https://localhost:44305/api/UserApi");
            var response = client.PostAsJsonAsync<Register>("UserApi", CreateView);
            response.Wait();

            var check = response.Result;
            if (check.IsSuccessStatusCode)
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
        public ActionResult Login(LoginScenario.Models.Register LoginView)
        {
            using (LoginScenarioEntities LoginDBModel = new LoginScenarioEntities())
            {
                var response = LoginDBModel.Registers.Where(loginmodel => loginmodel.Username == LoginView.Username && loginmodel.Password == LoginView.Password).FirstOrDefault();
                if (response == null)
                {
                    LoginView.LoginErrorMessage = "Wrong Username and Password";
                    return View("Login", LoginView);
                }
                else
                {
                    Session["Id"] = response.Id;
                    return RedirectToAction("Details", "UserMvc");
                }
            }
        }
        public ActionResult Details(int id)
        {
            Register DetailsView = null;
            client.BaseAddress = new Uri("https://localhost:44305/api/UserApi");
            var response = client.GetAsync("UserApi?id=" + id.ToString());
            response.Wait();

            var check = response.Result;
            if (check.IsSuccessStatusCode)
            {
                var display = check.Content.ReadAsAsync<Register>();
                display.Wait();
                DetailsView = display.Result;
            }
            return View(DetailsView);
        }
        public ActionResult Edit(int id)
        {
            Register EditView = null;
            client.BaseAddress = new Uri("https://localhost:44305/api/UserApi");
            var response = client.GetAsync("UserApi?id=" + id.ToString());
            response.Wait();

            var check = response.Result;
            if (check.IsSuccessStatusCode)
            {
                var display = check.Content.ReadAsAsync<Register>();
                display.Wait();
                EditView = display.Result;
            }
            return View(EditView);
        }
        [HttpPost]
        public ActionResult Edit(Register EditView)
        {
            client.BaseAddress = new Uri("https://localhost:44305/api/UserApi");
            var response = client.PutAsJsonAsync<Register>("UserApi", EditView);
            response.Wait();

            var check = response.Result;
            if (check.IsSuccessStatusCode)
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
                return Json(new SelectList( countries, "CountryCode", "CountryName"), JsonRequestBehavior.AllowGet);
            }

            return View(countries);
        }

        public ActionResult StateList(string CountryCode)
        {
            IQueryable states = State.GetStates().Where(statemodel => statemodel.CountryCode == CountryCode);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList( states, "StateID", "StateName"), JsonRequestBehavior.AllowGet);

            return View(states);
        }

        public ActionResult CityList()
        {
            IQueryable cities = City.GetCities(); //.Where(citymodel => citymodel.StateID == stateId);

            if (HttpContext.Request.IsAjaxRequest())
                return Json(new SelectList( cities, "CityCode", "Cityname"), JsonRequestBehavior.AllowGet);

            return View(cities);
        }
    }
}