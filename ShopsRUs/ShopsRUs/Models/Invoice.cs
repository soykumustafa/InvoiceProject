
using System.ComponentModel;

namespace ShopsRUs.Models
{
    public class Invoice //Faturalar
    {
        [DisplayName("Fatura Id")]
        public int InvoiceId { get; set; }

        [DisplayName("Personel ID")]
        public int EmployeeId { get; set; }

        [DisplayName("Bağlı Kurum Id")]
        public int AffiliateId { get; set; }

        [DisplayName("Müşteri ID")]
        public int CustomerID { get; set; }

        [DisplayName("Satış Durumu")]
        public string ShopStatus { get; set; }

        [DisplayName("Satış Tutarı")]
        public decimal price { get; set; }

        [DisplayName("Kayıt tarihi")]
        public DateTime InsertDate { get; set; }

        [DisplayName("Aktif mi")]
        public bool IsActive { get; set; }
    }
}
