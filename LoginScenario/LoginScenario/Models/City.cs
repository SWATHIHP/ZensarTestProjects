using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistration.Models
{
    public class City
    {
        public int StateID { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }

        public static IQueryable<City> GetCities()
        {
            return new List<City>
            {
                new City { StateID = 7, CityCode = "NP", CityName = "Nagpur" },
                new City { StateID = 7, CityCode = "NH", CityName = "Nashik" },
                new City { StateID = 7, CityCode = "MB", CityName = "Mumbai" },
                new City { StateID = 7, CityCode="PN", CityName="Pune"},
                new City { StateID = 7, CityCode="AM", CityName="Amravati"}


            }.AsQueryable();
        }
    }
}