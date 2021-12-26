
using System.ComponentModel;

namespace ShopsRUs.Models
{
    public class Affiliate
    {
        [DisplayName("Bağlı Kurum Id")]
        public int AffiliateId { get; set; }

        [DisplayName("Kurum Adı")]
        public string Name { get; set; }

        [DisplayName("Kayıt tarihi")]
        public DateTime InsertDate { get; set; }

        [DisplayName("Aktif mi")]
        public bool IsActive { get; set; }
    }
}
