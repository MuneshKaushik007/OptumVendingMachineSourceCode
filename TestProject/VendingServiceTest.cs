using OptumVendingMachine;
using OptumVendingMachine.Models.Coins;
using OptumVendingMachine.Models.Products;
using Xunit.Sdk;

namespace VendingMachineTestProject
{
    [TestClass]
    public class VendingServiceTest
    {
        [TestMethod]        
        public void ValidatePaidAmount_WhenSuccess()
        {
            VendingService vendingService = new VendingService();
            vendingService.AddCoin(new Quarters());
            vendingService.AddCoin(new Quarters());
            var isValid = vendingService.ValidatePaidAmount(new Chips());

            Assert.AreEqual(false,isValid);
        }

        [TestMethod]
        public void ValidatePaidAmount_WhenFail()
        {
            VendingService vendingService = new VendingService();
            vendingService.AddCoin(new Nickels());
            var isValid = vendingService.ValidatePaidAmount(new Chips());
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void ValidateInsertedCoin_WhenSuccess()
        {
            VendingService vendingService = new VendingService();           
            var isValid = vendingService.ValidateCoin(new Nickels());
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void ValidateInsertedCoin_WhenFail()
        {
            VendingService vendingService = new VendingService();
            var isValid = vendingService.ValidateCoin(new Pennies());
            Assert.AreEqual(false, isValid);
        }
    }
}