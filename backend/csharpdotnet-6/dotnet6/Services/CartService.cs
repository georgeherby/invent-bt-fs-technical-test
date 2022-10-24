using System;
using dotnet6.Interfaces;
using dotnet6.Models;

namespace dotnet6.Services
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
