using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalTotalFare()
        {
            //Arrange
            CabInvoice cabInvoice = new CabInvoice();

            //Act
            int fare = cabInvoice.CalculateFare(10, 30);
            //Assert
            Assert.AreEqual(130, fare);

        }

        [TestMethod]
        public void CheckMinimumFairAsFive()
        {
            //Arrange
            CabInvoice cabInvoice = new CabInvoice();

            double fare = cabInvoice.CalculateFare(0, 0);
            Assert.AreEqual(5, fare);
        }

        [TestMethod]
        public void CalAggFairAndMultipleRide()
        {
            CabInvoice cabInvoice = new CabInvoice();
            cabInvoice.AddRide(2, 5);
            cabInvoice.AddRide(12, 15);
            double fare = cabInvoice.CalculateAggregate();
            Assert.AreEqual(160, fare);
        }
    }
}
    
