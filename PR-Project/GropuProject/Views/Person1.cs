using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace GropuProject.Views
{
    public class Person1
    {
        public int Id { get; set; }
        public string ProName { get; set; }
        public int ProPrice { get; set; }
        public int SalesTax { get; set; }
       
        public int ProQuantity { get; set; }
        

        public Person1(int id, string proName, int proPrice, int salesTax, int proQuantity)
        {
            Id = id;
            ProName = proName;
            ProPrice = proPrice;
            SalesTax = salesTax;
            ProQuantity = proQuantity;
        }

        public Person1()
        {
        }
    }
}
