using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptumVendingMachine.Models.Coins;
using OptumVendingMachine.Models.Products;

namespace OptumVendingMachine
{
    public class VendingService
    {
        public bool Validate(List<Coin> lstCoin, Product product, double totalCoinAmount)
        {

            // iterate list and find total cost of coin
            if (lstCoin.Count == 0)
            {
                return true;
            }

            foreach (var item in lstCoin)
            {
                totalCoinAmount += Math.Round(item.Rate, 2);
            }
            totalCoinAmount = Math.Round(totalCoinAmount, 2);
            if (product.Price <= totalCoinAmount)
            {
                Console.WriteLine("Total amount inserted $" + totalCoinAmount);
                totalCoinAmount = 0.0;
                return false;
            }
            else
            {
                Console.WriteLine("Price of " + product.Name + " is $" + product.Price);
                Console.WriteLine("Please add more coin with pending amount $" + (product.Price - totalCoinAmount));

                return true;
            }

        }
    }
}
