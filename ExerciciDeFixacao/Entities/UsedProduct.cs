using System;
using System.Globalization;

namespace ExerciciDeFixacao.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufacture) : base(name, price)
        {
            ManufactureDate = manufacture;
        }

        public override string PriceTag()
        {
            return Name + "(used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                 + " (Manufactured date(" + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
