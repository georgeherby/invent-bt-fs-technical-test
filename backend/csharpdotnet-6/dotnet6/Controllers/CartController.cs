using dotnet6.Interfaces;
using dotnet6.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6.Controllers;

[ApiController]
[Produces("application/json")]
[Route("[controller]")]
public class CartController : ControllerBase
{
    private readonly ICartService _cartService;

    public CartController(ICartService cartService)
    {
        _cartService = cartService;
    }

    [Route("Items")]
    [HttpGet]
    public ActionResult<ItemsResponse> GetShopItems()
    {
        return Ok(new ItemsResponse(
            new List<Product>()
            {
                    new Product("Apple", 60),
                    new Product("Orange", 25)
            }
            )
        );
    }

    [Route("Add")]
    [HttpPost]
    public ActionResult<double> AddItemsToShoppingCart(string[] items)
    {
        throw new NotImplementedException();
    }

    [Route("Total")]
    [HttpGet]
    public ActionResult<double> GetTotalPrice()
    {
        throw new NotImplementedException();
    }

    [Route("Remove")]
    [HttpDelete]
    public ActionResult<double> RemoveItemFromShoppingCart(string[] items)
    {
        throw new NotImplementedException();
    }
}

