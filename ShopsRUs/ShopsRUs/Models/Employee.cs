
using System.ComponentModel;

namespace ShopsRUs.Models
{
    public class Employee //Personeller
    {
        [DisplayName("Personel Id")]
        public int EmployeeId { get; set; }

        [DisplayName("Personel Adı")]
        public string Name { get; set; }

        [DisplayName("Personel Soyadı")]
        public string Surname { get; set; }

        [DisplayName("Kayıt tarihi")]
        public DateTime InsertDate { get; set; }

        [DisplayName("Aktif mi")]
        public bool IsActive { get; set; }
    }
}
