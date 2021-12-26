using ShopsRUs.Models;

namespace ShopsRUs.Bussines
{
    public class Price
    {
        public decimal GetPrice(int id)
        {
            var p = DataRepository._invoices.FirstOrDefault(i => i.InvoiceId == id);
            string status = "";
            decimal price = 0;

            if (p.ShopStatus != "Market")//Koşul market alışverişi değil ise
            {
                if (p.EmployeeId > 0)
                {
                    var em = DataRepository._employees.FirstOrDefault(i => i.EmployeeId == p.EmployeeId && i.IsActive == true);
                    if (em != null)
                        status = "Employee"; //Koşul Personel İse
                }
                else if (p.AffiliateId > 0)
                {
                    var af = DataRepository._affiliates.FirstOrDefault(i => i.AffiliateId == p.AffiliateId && i.IsActive == true);
                    if (af != null)
                        status = "Affiliate";//Koşul mağazaya bağlı kurum ise
                }
                else if (p.CustomerID > 0)
                {
                    var cu = DataRepository._customers.FirstOrDefault(i => i.CustomerId == p.CustomerID && i.IsActive == true);
                    if (cu != null)
                    {
                        if (cu.InsertDate < DateTime.Now.AddYears(-2))
                        {
                            status = "CustomerTwoYears";//Koşul 2 yıldan fazla müşteri ise
                        }
                    }
                }
            }
            else
            {
                status = "FivePercent";
            }

            PriceAccountDetail _priceDetail = new PriceAccountDetail();

            if (status.Equals("Employee")) //Koşul Personel İse ve Alışveriş Türü Market değil ise
            {
                price= _priceDetail.GetEmployee(p.price);
            }
            else if (status.Equals("Affiliate"))//Koşul mağazaya bağlı kurum ise ve Alışveriş Türü Market değil ise
            {
                price = _priceDetail.GetAffiliate(p.price);
            }
            else if (status.Equals("CustomerTwoYears")) //Koşul 2 yıldan fazla müşteri ise ve Alışveriş Türü Market değil ise
            {
                price = _priceDetail.GetCustomer(p.price);
            }
            else if(status.Equals("FivePercent")) // Faturadaki her 100 TL  için 5 TL indirim olacaktır 
            {
                price = _priceDetail.GetFivePercent(p.price);
            }
            return (price);


        }

    }
}
