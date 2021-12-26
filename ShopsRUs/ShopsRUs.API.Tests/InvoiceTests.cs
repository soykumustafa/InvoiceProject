using ShopsRUs.Bussines;
using Xunit;

namespace ShopsRUs.API.Tests
{
    public class InvoiceTests
    {
        [Fact]
        public void EmployeeTest()
        {
            #region Arrange
            decimal price1 = 250;
            int expected = 175;
            PriceAccountDetail Pa = new PriceAccountDetail();
            #endregion
            #region Act
            double result = (double)Pa.GetEmployee(price1);
            #endregion
            #region Assert
            Assert.Equal(result, expected);
            #endregion
        }

        [Fact]
        public void AffiliateTest()
        {
            #region Arrange
            decimal price1 = 250;
            int expected = 225;
            PriceAccountDetail Pa = new PriceAccountDetail();
            #endregion
            #region Act
            double result = (double)Pa.GetAffiliate(price1);
            #endregion
            #region Assert
            Assert.Equal(result, expected);
            #endregion
        }

        [Fact]
        public void CustomerTest()
        {
            #region Arrange
            decimal price1 = 300;
            int expected = 285;
            PriceAccountDetail Pa = new PriceAccountDetail();
            #endregion
            #region Act
            double result = (double)Pa.GetCustomer(price1);
            #endregion
            #region Assert
            Assert.Equal(result, expected);
            #endregion
        }

        [Fact]
        public void FivePercentTest()
        {
            #region Arrange
            decimal price1 = 250;
            int expected = 240;
            PriceAccountDetail Pa = new PriceAccountDetail();
            #endregion
            #region Act
            double result = (double)Pa.GetFivePercent(price1);
            #endregion
            #region Assert
            Assert.Equal(result, expected);
            #endregion
        }


    }
}