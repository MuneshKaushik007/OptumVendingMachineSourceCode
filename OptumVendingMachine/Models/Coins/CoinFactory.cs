using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Constants;
using OptumVendingMachine.Models.Products;

namespace OptumVendingMachine.Models.Coins
{
    public class CoinFactory : ICoin
    {
        public Coin GetCoin(CoinEnum name)
        {
            switch (name)
            {
                case CoinEnum.Nickel:
                    return new Nickels();
                case CoinEnum.Dimes:
                    return new Dimes();
                case CoinEnum.Quarter:
                    return new Quarters();
                case CoinEnum.Pennie:
                    return new Pennies();
                default:                    
                    throw new NotImplementedException();
            }
        }
    }
}
