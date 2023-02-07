using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Constants;

namespace OptumVendingMachine.Models.Coins
{
    public class Quarters : Coin
    {
        public Quarters() : base()
        {
            Name = Constant.Quarter;
            Rate = 0.25;
        }
    }
}
