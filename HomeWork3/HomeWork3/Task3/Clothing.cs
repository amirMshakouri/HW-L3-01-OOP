using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task3
{
    public class Clothing : Product
    {
        public string Size { get; set; }

        public string Material { get; set; }

        public Clothing(string name, Decimal price, string size, string material)
            : base(name, price)
        {
            Size = size;
            Material = material;
        }

        public override string GetProductDetails()
        {
            return $"Cloths\n" +
                   $"Name: {Name}\n" +
                   $"Price: {Price}\n" +
                   $"Size: {Size}\n" +
                   $"Material: {Material}";
        }
    }
}
