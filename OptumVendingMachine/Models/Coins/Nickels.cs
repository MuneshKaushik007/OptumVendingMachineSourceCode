using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Constants;

namespace OptumVendingMachine.Models.Coins
{
    public class Nickels : Coin
    {
        public Nickels() : base()
        {
            Name = Constant.Nickel;
            Rate = 0.05;
        }
    }
}
