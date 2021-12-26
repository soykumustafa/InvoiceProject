using ShopsRUs.Models;

namespace ShopsRUs.Bussines
{
    public class DataRepository
    {
        public static List<Invoice> _invoices = new List<Invoice>();
        public static List<Customer> _customers = new List<Customer>();
        public static List<Employee> _employees = new List<Employee>();
        public static List<Affiliate> _affiliates = new List<Affiliate>();
        public void Insert()
        {

            //I added invoices manually (Faturaları manuel ekledim)

            _invoices.Add(new Invoice() { InvoiceId = 1, EmployeeId = 1, AffiliateId = 1, CustomerID = 2, price = 400, InsertDate = DateTime.Now, IsActive = true, ShopStatus = "Cosmetic" });
            _invoices.Add(new Invoice() { InvoiceId = 2, EmployeeId = 2, AffiliateId = 0, CustomerID = 3, price = 300, InsertDate = DateTime.Now, IsActive = true, ShopStatus = "Cosmetic" });
            _invoices.Add(new Invoice() { InvoiceId = 3, EmployeeId = 0, AffiliateId = 0, CustomerID = 1, price = 500, InsertDate = DateTime.Now, IsActive = true, ShopStatus = "Cosmetic" });
            _invoices.Add(new Invoice() { InvoiceId = 4, EmployeeId = 0, AffiliateId = 0, CustomerID = 4, price = 545, InsertDate = DateTime.Now, IsActive = true, ShopStatus = "Cosmetic" });
            _invoices.Add(new Invoice() { InvoiceId = 5, EmployeeId = 1, AffiliateId = 1, CustomerID = 2, price = 400, InsertDate = DateTime.Now, IsActive = true, ShopStatus = "Market" });

            //I added customers manually (Müşterileri manuel ekledim)
            _customers.Add(new Customer() { CustomerId = 1, Name = "Sena", Surname = "Hasanoğlu", InsertDate = Convert.ToDateTime("2017-12-22 16:40:07.550"), IsActive = true });
            _customers.Add(new Customer() { CustomerId = 2, Name = "Ayşe", Surname = "Mikyas", InsertDate = Convert.ToDateTime("2021-12-22 16:40:07.550"), IsActive = true });
            _customers.Add(new Customer() { CustomerId = 3, Name = "Meryem", Surname = "Sarılı", InsertDate = Convert.ToDateTime("2020-12-22 16:40:07.550"), IsActive = true });
            _customers.Add(new Customer() { CustomerId = 4, Name = "Tuna", Surname = "Can", InsertDate = Convert.ToDateTime("2022-12-22 16:40:07.550"), IsActive = true });

            //I added Employees manually (Personelleri manuel ekledim)
            _employees.Add(new Employee() { EmployeeId = 1, Name = "Hasan", Surname = "Meryem", InsertDate = Convert.ToDateTime("2017-12-22 16:40:07.550"), IsActive = true });
            _employees.Add(new Employee() { EmployeeId = 2, Name = "Ayşe", Surname = "Mikyas", InsertDate = Convert.ToDateTime("2017-12-22 16:40:07.550"), IsActive = true });
            _employees.Add(new Employee() { EmployeeId = 3, Name = "Cansu", Surname = "Dere", InsertDate = Convert.ToDateTime("2017-12-22 16:40:07.550"), IsActive = true });
            _employees.Add(new Employee() { EmployeeId = 4, Name = "Pınar", Surname = "Tuna", InsertDate = Convert.ToDateTime("2017-12-22 16:40:07.550"), IsActive = true });

            //I added Affiliates manually (Bağlı kuruluşları manuel ekledim)
            _affiliates.Add(new Affiliate() { AffiliateId = 1, Name = "Melis giyim", InsertDate = DateTime.Now, IsActive = true });
            _affiliates.Add(new Affiliate() { AffiliateId = 2, Name = "Can giyim", InsertDate = DateTime.Now, IsActive = true });
        }

    }
}
