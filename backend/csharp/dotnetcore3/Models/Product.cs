using System;
namespace dotnetcore3.Models
{
    public class Product
    {
        public string ItemName { get; set; }

        public int Price { get; set; }

        public Product(string item_name, int price)
        {
            ItemName = item_name;
            Price = price;
        }
    }
}

