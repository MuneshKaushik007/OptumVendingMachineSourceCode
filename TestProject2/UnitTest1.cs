using OptumVendingMachine;
using OptumVendingMachine.Models.Coins;
using OptumVendingMachine.Models.Products;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            VendingService vendingService = new VendingService();
            double totalCoinAmount = 0.1;
            var list = new List<Coin>();
            list.Add(new Dimes());
            var isValid = vendingService.Validate(list, new Chips(), totalCoinAmount);

            Assert.AreEqual(true, isValid);
        }
    }
}