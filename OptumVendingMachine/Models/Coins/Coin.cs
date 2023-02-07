using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptumVendingMachine.Models.Coins
{
    public abstract class Coin
    {
        public string? Name { get; set; }
        public double Rate { get; set; }
    }
}
