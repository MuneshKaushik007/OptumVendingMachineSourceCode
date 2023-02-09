// See https://aka.ms/new-console-template for more information
using OptumVendingMachine;
using OptumVendingMachine.Constants;
using OptumVendingMachine.Models.Coins;
using OptumVendingMachine.Models.Products;

Console.WriteLine("Welcome to Optum Vending Machine");
Console.WriteLine("What would you like to take?");
Console.WriteLine("Press 1 for Cola");
Console.WriteLine("Press 2 for Chips");
Console.WriteLine("Press 3 for Candy");

var options = Convert.ToInt32(Console.ReadLine());
IProduct productFactory = new ProductFactory();
Product product = productFactory.GetProduct(options);
Console.WriteLine("Selected product name is " + product.Name);

Console.WriteLine("Please insert amount $" + product.Price);
Console.WriteLine("Available coin options");


VendingService vendingService = new VendingService();
while (vendingService.ValidatePaidAmount(product))
{
    // need to show coin list
    Console.WriteLine("Nickel ($ 1/20)");
    Console.WriteLine("Dimes ($ 1/10)");
    Console.WriteLine("Quarter ($ 1/4)");
    Console.WriteLine("Pennie ($ 1/100)"); 
    var coinOption = Console.ReadLine();
    try
    {
        ICoin coinFactory = new CoinFactory();
        Coin coin = coinFactory.GetCoin((CoinEnum)Enum.Parse(typeof(CoinEnum), coinOption));
        vendingService.AddCoin(coin);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Please insert valid coin!");
    }
}

Console.WriteLine("Your " + product.Name + " is dispensed! Enjoy");
Console.WriteLine("Thank you");
