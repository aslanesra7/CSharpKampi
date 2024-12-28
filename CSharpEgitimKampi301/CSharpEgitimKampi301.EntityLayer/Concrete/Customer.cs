using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCity { get; set; }
        public bool CustomerStatus { get; set; }

        public List<Order> Orders { get; set; }
    }
}
/* Her bir class o classa ait proplarla eşleştiriliyor
 * solid->Single responsibility prensibine denk gelir bu yaklaşım
 * tek sorumluluk ilkesi:bir bileşen bağlı bulunduğu alanda sadece tek bir işlem yapmalı
 */
