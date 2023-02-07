using OptumVendingMachine;
using OptumVendingMachine.Models.Coins;
using OptumVendingMachine.Models.Products;
using Xunit.Sdk;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Utility utility = new Utility();
            double totalCoinAmount = 0.25;
            var list=new List<Coin>();
            list.Add(new Quarters());
            var isValid = utility.Validate(list, new Chips(), totalCoinAmount);

            Assert.AreEqual(false,isValid);
        }
    }
}