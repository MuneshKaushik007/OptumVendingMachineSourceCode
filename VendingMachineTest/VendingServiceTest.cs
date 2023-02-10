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
        public void ValidatePaidAmount_InsertedTwoQuarterForDispenseProduct_WhenSuccess()
        {
            VendingService vendingService = new VendingService();
            vendingService.AddCoin(new Quarters());
            vendingService.AddCoin(new Quarters());
            var isValid = vendingService.ValidatePaidAmount(new Chips());

            Assert.AreEqual(false,isValid);
        }

        [TestMethod]
        public void ValidatePaidAmount_InsertedOneNickelForNotDispenseProduct_WhenFail()
        {
            VendingService vendingService = new VendingService();
            vendingService.AddCoin(new Nickels());
            var isValid = vendingService.ValidatePaidAmount(new Chips());
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void ValidateInsertedCoin_WhenInsertedNickelCoin_Success()
        {
            VendingService vendingService = new VendingService();           
            var isValid = vendingService.ValidateCoin(new Nickels());
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        public void ValidateInsertedCoin_WhenInsertedPennieCoin_Fail()
        {
            VendingService vendingService = new VendingService();
            var isValid = vendingService.ValidateCoin(new Pennies());
            Assert.AreEqual(false, isValid);
        }
    }
}