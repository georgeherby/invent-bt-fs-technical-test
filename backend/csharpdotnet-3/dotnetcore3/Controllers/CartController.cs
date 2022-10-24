using System;
using System.Collections.Generic;
using System.Linq;
using dotnetcore3.Interfaces;
using dotnetcore3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetcore3.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        [Route("items")]
        [HttpGet]
        public ActionResult<ItemsResponse> GetShopItems()
        {
            return Ok(new ItemsResponse(_cartService.GetProducts()));
        }

        [Route("total")]
        [HttpPost]
        public ActionResult<double> TotalPrice(string[] items)
        {
            throw new NotImplementedException();
        }
    }
}

