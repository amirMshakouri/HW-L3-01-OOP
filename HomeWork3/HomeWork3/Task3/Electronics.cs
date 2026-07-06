using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task3
{
    public class Electronic : Product, IDiscountable
    {
        public int WarrantyPeriod { get; set; }

        public Electronic(string name, Decimal price, int warrantyPeriod)
            : base(name, price)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public void ApplyDiscount(Decimal percentage)
        {
            Price -= Price * percentage / 100;
        }

        public override string GetProductDetails()
        {
            return $"Electronics product \n" +
                   $"Electronics product Name: {Name}\n" +
                   $"Electronics product Price: {Price}\n" +
                   $"Electronics product Warranty: {WarrantyPeriod} Months ";
        }
    }
}
