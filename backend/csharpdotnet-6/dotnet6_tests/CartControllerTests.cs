using dotnet6.Controllers;
using dotnet6.Interfaces;
using dotnet6.Models;
using dotnet6.Services;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6_tests;

public class CartControllerTests
{
    [Fact]
    public void ShouldReturnListOfItems()
    {
        var cartService = new CartService();
        var controller = new CartController(cartService);

        var result = controller.GetShopItems();

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var itemsResponse = Assert.IsType<ItemsResponse>(okResult.Value);
        var productList = itemsResponse.ProductList;
        Assert.Equal("Apple", productList[0].ItemName);
        Assert.Equal(25, productList[1].Price);
    }
}
