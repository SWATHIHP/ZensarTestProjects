using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegisterUser.Models
{
    public class Country
    {
        public string Ccode { get; set; }
        public string Cname { get; set; }
        public static IQueryable<Country> GetCountries()
        {
            return new List<Country>
            {
               new Country
               {
                   Ccode="US",
                   Cname="United States"
               },
               new Country
               {
                   Ccode="KR",
                   Cname="South Korea"
               },
               new Country
               {
                   Ccode="IN",
                   Cname="India"
                   
               }
            }.AsQueryable();
        }
    }
}