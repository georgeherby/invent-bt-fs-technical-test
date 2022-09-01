using System;
using System.Collections.Generic;

namespace dotnetcore3.Models
{
    public class ItemsResponse
    {
        public List<Product> ProductList { get; set; }

        public ItemsResponse(List<Product> productList)
        {
            ProductList = productList;
        }
    }
}

