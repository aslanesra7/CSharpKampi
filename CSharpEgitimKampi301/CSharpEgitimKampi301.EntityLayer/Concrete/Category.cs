using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } //sınıf+Id yazınca birincil anahtar olduğunu anlıyor
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }

    }
}
/*
 Field-Variable-Property

 classın içinde tanımlanırsa field
int x;

get ve setle beraber tanımlanırsa property
public int y {get;set;}

metodun içinde tanımlanırsa variable
void test()
{
  int z;
}
 */
