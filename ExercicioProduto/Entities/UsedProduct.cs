using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioProduto.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufacutureDate{ get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufacutureDate) : base(name,price)
        {
            ManufacutureDate = manufacutureDate;
        }
        public override string priceTag()
        {
            return Name + "(used) "+ "$ " + Price.ToString("F2",CultureInfo.InvariantCulture) + " Manufacture date: " + ManufacutureDate.ToString("dd/MM/yyyy)") + ")";
        }
    }
}
