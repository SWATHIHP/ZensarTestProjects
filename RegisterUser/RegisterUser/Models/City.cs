using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegisterUser.Models
{
    public class City
    {
        //public string Ccode { get; set; }
        public string Scode { get; set; }
        public string  Ctcode { get; set; }
        public string Cityname { get; set; }
        public static IQueryable<City> GetCities()
        {
            return new List<City>
            {
                new City
                {
                   
                    Scode="Ka",
                    Ctcode="Bgl",
                    Cityname="Banglore"
                },
                new City
                    {
                        
                        Scode="Ka",
                        Ctcode="Mang",
                        Cityname="Manglore"
                    },
                 new City
                    {

                        Scode="Sl",
                        Ctcode="Bs",
                        Cityname="Busan"
                    },
                new City
                {
                     Scode="Pj",
                     Ctcode="Amr",
                     Cityname="Amritsar"
                }
            }.AsQueryable();
        }
    }
}