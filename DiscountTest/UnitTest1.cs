using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DiscountTest
{
    //Tests for the GetDiscount function
    [TestClass]
    public class UnitTest1
    {
        private const double ExpectedValue1 = 0;
        private const double ExpectedValue2 = 0.09; // log10(100)/100 + 0.05 + 0.02 = 0.09

        [TestMethod]
        public void TestMethod1()
        {
            Test_Program.Models.Discounts discounts = new Test_Program.Models.Discounts(0, 0, 0);
            var discount = discounts.GetDiscount();

            Assert.AreEqual(discount, ExpectedValue1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Test_Program.Models.Discounts discounts = new Test_Program.Models.Discounts(100, 0.05, 0.02);
            var discount = discounts.GetDiscount();

            Assert.AreEqual(discount, ExpectedValue2);
        }
    }
}
