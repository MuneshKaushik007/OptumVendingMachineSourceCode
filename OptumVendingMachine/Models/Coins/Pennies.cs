using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Constants;

namespace OptumVendingMachine.Models.Coins
{
    public class Pennies : Coin
    {
        public Pennies() : base()
        {
            Name = Constant.Pennie;
            Rate = 0.01;
        }
    }
}
