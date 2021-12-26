
using System.ComponentModel;

namespace ShopsRUs.Models
{
    public class Customer  //Müşteriler
    {
        [DisplayName("Müşteri Id")]
        public int CustomerId { get; set; }

        [DisplayName("Müşteri Adı")]
        public string Name { get; set; }

        [DisplayName("Müşteri Soyadı")]
        public string Surname { get; set; }

        [DisplayName("Kayıt tarihi")]
        public DateTime InsertDate { get; set; }

        [DisplayName("Aktif mi")]
        public bool IsActive { get; set; }
    }
}
