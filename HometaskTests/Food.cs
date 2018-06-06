using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HometaskTests
{
    class Food
    {
        public List<string> Candies { get; set; }

        public Food()
        {
            Candies = new List<string>()
            {
               "Lolly-pop",
               "Snickers",
                "Toblerone",
                 "Twix"
            };
        }
    }
}
