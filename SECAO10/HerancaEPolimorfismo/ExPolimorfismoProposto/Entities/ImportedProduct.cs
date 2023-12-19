﻿using System.Globalization;

namespace ExPolimorfismoProposto.Entities
{
    class ImportedProduct : Product
    {
        public Double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            :base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return $"{Name} ${TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Customs fee: ${CustomsFee.ToString("F2", CultureInfo.InvariantCulture)})";
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}
