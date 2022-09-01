using System;
namespace dotnet6.Models
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

