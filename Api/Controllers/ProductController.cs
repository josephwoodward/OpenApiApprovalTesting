using System.Collections.Generic;
using Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ProductViewModel>> Get()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, ProductName = "Product 1"},
                new ProductViewModel {Id = 2, ProductName = "Product 1"},
                new ProductViewModel {Id = 3, ProductName = "Product 1"}
            };
        }
    }
}