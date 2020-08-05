using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioProduto.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree) : base(name,price)
        {
            CustomsFree = customsFree;
        }
        public double totalPrice()
        {
            return Price + CustomsFree;
        }
        public override string priceTag()
        {
            return Name + " $ " + totalPrice().ToString("F2",CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFree.ToString("F2",CultureInfo.InvariantCulture) + ")";
        }
    }
}
