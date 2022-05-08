using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RegisterUser.Models
{
    public class State
    {
        public string Ccode { get; set; }
        public string Scode { get; set; }
        public string Sname { get; set; }
        public static IQueryable<State> GetStates()
        {
            return new List<State>
            {
                new State
                {
                    Ccode="US",
                    Scode="Alb",
                    Sname="Alabama"
                },
                 new State
                {
                    Ccode="US",
                    Scode="Flr",
                    Sname="Florida"
                },
                  new State
                {
                    Ccode="US",
                    Scode="Grg",
                    Sname="Georgia"
                },
                   new State
                {
                    Ccode="US",
                    Scode="Kns",
                    Sname="Kansas"
                },
                    new State
                {
                    Ccode="US",
                    Scode="Txs",
                    Sname="Texas"
                },
                    new State
                    {
                        Ccode="IN",
                        Scode="Dlh",
                        Sname="Delhi"
                    },
                     new State
                    {
                        Ccode="IN",
                        Scode="Krl",
                        Sname="Kerala"
                    },
                      new State
                    {
                        Ccode="IN",
                        Scode="Ga",
                        Sname="Goa"
                    },
                       new State
                    {
                        Ccode="IN",
                        Scode="Pj",
                        Sname="Punjab"
                    },
                         new State
                    {
                        Ccode="KR",
                        Scode="Sl",
                        Sname="Seoul"
                    },
                        new State
                    {
                        Ccode="IN",
                        Scode="Ka",
                        Sname="Karnataka"
                    },
            }.AsQueryable();
        }

    }
}