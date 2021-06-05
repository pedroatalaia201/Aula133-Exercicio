using System;
using System.Globalization;

namespace ExerciciDeFixacao.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double fee) : base(name, price)
        {
            CustomsFee = fee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                 + "(Customs fee: $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ")";  
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
