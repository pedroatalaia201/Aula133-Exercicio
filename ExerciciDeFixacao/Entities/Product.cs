﻿using System;
using System.Globalization;

namespace ExerciciDeFixacao.Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() {
        }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        /*
          public virtual void PriceTag() {
             Console.WriteLine(Name + " $ " + Price.ToString("F2",CultureInfo.InvariantCulture));
         }  
         */

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
