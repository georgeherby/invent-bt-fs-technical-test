using System;
using System.Collections.Generic;
using dotnetcore3.Models;

namespace dotnetcore3.Interfaces
{
    public interface ICartService
    {
        public List<Product> GetProducts();
    }
}

