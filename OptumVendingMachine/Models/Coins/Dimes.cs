using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Constants;

namespace OptumVendingMachine.Models.Coins
{
    public class Dimes : Coin
    {
        public Dimes() : base()
        {
            Name = Constant.Dime;
            Rate = 0.1;
        }
    }
}
