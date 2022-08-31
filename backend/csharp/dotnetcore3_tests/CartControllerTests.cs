using System;
using System.Text.Json;
using Xunit;
using Moq;
using dotnetcore3.Interfaces;
using dotnetcore3.Controllers;
using dotnetcore3.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore3_tests
{
    public class CartControllerTests
    {
        [Fact]
        public void ShouldReturnListOfItems()
        {
            var mockCartService = new Mock<ICartService>();
            var controller = new CartController(mockCartService.Object);

            var result = controller.GetShopItems();

            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var itemsResponse = Assert.IsType<ItemsResponse>(okResult.Value);
            var productList = itemsResponse.ProductList;
            Assert.Equal("Apple", productList[0].ItemName);
            Assert.Equal(25, productList[1].Price);
        }
    }
}

