using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistration.Models
{
    public class State
    {
        public string CountryCode { get; set; }
        public int StateID { get; set; }
        public string StateName { get; set; }

        public static IQueryable<State> GetStates()
        {
            return new List<State>
            {
                new State { CountryCode = "CA", StateID=1, StateName = "Ontario"},
                new State { CountryCode = "CA", StateID=2, StateName = "Nova Scotia"},
                new State { CountryCode = "CA", StateID=3, StateName = "British Columbia"},
                new State { CountryCode = "CA", StateID=4, StateName = "Prince Edward Island"},
                new State { CountryCode = "CA", StateID=5, StateName = "Saskatchewan"},
                new State { CountryCode = "IN", StateID=6, StateName = "Assam"},
                new State { CountryCode = "IN", StateID=7, StateName = "Maharashtra"},
                new State { CountryCode = "IN", StateID=8, StateName = "Bihar"},
                new State { CountryCode = "IN", StateID=9, StateName = "Karnataka"},
                new State { CountryCode = "IN", StateID=10, StateName = "Ladakh"},
                new State { CountryCode = "SK", StateID=11, StateName = "Gangwon"},
                new State { CountryCode = "SK", StateID=12, StateName = "Jeju"},
                new State { CountryCode = "SK", StateID=13, StateName = "Chungcheong"},
                new State { CountryCode = "SK", StateID=14, StateName = "Gyeongsang"},
                new State { CountryCode = "SK", StateID=15, StateName = "Jeolla"},
                new State { CountryCode = "US", StateID=16, StateName = "Florida"},
                new State { CountryCode = "US", StateID=17, StateName = "New-York"},
                new State { CountryCode = "US", StateID=18, StateName = "California"},
                new State { CountryCode = "US", StateID=19, StateName = "Washington"},
                new State { CountryCode = "US", StateID=20, StateName = "Vermont"}
            }.AsQueryable();
        }
    }
}