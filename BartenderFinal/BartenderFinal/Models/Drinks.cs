using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BartenderFinal.Models
{
    public class Drinks
    {
        public string DrinkName { get; set; }
        public int DrinkID { get; set; }

        public List<DrinkOrder> DrinkOrders { get; set; }
    }
}
