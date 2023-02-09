using OptumVendingMachine.Models.Coins;
using OptumVendingMachine.Models.Products;

namespace OptumVendingMachine
{
    public class VendingService
    {
        List<Coin> insertedCoin = new List<Coin>();       
        double returnCoinAmount = 0.0;
        /// <summary>
        /// Calculate and validate paid amount
        /// </summary>      
        /// <param name="product"></param>
        /// <param name="totalCoinAmount"></param>
        /// <returns></returns>
        public bool ValidatePaidAmount(Product product)
        {
            // iterate list and find total cost of coin
            double totalCoinAmount = 0.0;
            if (insertedCoin.Count == 0)
            {
                return true;
            }

            foreach (var item in insertedCoin)
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
        /// <summary>
        /// Adding coin
        /// </summary>
        /// <param name="coin"></param>
        public void AddCoin(Coin coin)
        {
            if (ValidateCoin(coin))
            {
                insertedCoin.Add(coin);
            }            
        }
        /// <summary>
        /// Validating coin
        /// </summary>
        /// <param name="coin"></param>
        /// <returns></returns>
        public bool ValidateCoin(Coin coin)
        {
            if (coin is Pennies)
            {
                returnCoinAmount += coin.Rate;
                Console.WriteLine("Amount to return $" + returnCoinAmount);
                Console.WriteLine("Please insert valid coin..");
                return false;
            }
            return true;
        }
    }
}
