using System;
using System.Collections.Generic;
using dotnetcore3.Interfaces;
using dotnetcore3.Models;

namespace dotnetcore3.Services
{
    public class CartService : ICartService
    {
        List<Product> Products = new List<Product>();

        public CartService()
        {
            Products.Add(new Product("Apple", 60));
            Products.Add(new Product("Orange", 25));
        }

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}

