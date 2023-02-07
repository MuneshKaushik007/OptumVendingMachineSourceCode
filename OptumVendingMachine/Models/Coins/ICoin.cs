using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Constants;

namespace OptumVendingMachine.Models.Coins
{
    public interface ICoin
    {
        Coin GetCoin(CoinEnum name);
    }
}
