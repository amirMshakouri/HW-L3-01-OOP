using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task3
{
    public class Product
    {
        public string Name { get; set; }

        public Decimal Price { get; set; }

        public Product(string name, Decimal price)
        {
            Name = name;
            Price = price;
        }

        public virtual string GetProductDetails()
        {
            return $"ProductName: {Name}\n Price: {Price}";
        }
    }
}
