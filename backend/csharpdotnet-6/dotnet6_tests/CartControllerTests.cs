using dotnet6.Controllers;
using dotnet6.Interfaces;
using dotnet6.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_tests;

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
