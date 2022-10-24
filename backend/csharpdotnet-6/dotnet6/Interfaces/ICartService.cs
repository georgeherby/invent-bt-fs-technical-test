using System;
using dotnet6.Models;

namespace dotnet6.Interfaces
{
    public interface ICartService
    {
        public List<Product> GetProducts();
    }
}

