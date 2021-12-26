using ShopsRUs.Models;

namespace ShopsRUs.Bussines
{
    public class PriceAccountDetail
    {

        public decimal GetEmployee(decimal price)
        {
            return Math.Round((price - ((price * 30) / 100)));
        }
        public decimal GetAffiliate(decimal price)
        {
            return Math.Round((price - ((price * 10) / 100)));
        }
        public decimal GetCustomer(decimal price)
        {
            return Math.Round((price - ((price * 5) / 100)));
        }
        public decimal GetFivePercent(decimal price)
        {
            if (price > 100)
            {
                int priceDiscount = Convert.ToInt32(price);
                priceDiscount = ((priceDiscount / 100) * 5);
                return Math.Round((price - Convert.ToDecimal(priceDiscount)));
            }
            else
                return price;
        }
    

    }
}
