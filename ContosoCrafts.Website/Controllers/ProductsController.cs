using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Website.Models;
using ContosoCrafts.Website.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCrafts.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(MariaDBProductService productService)
        {
            this.ProductService = productService;
        }

        public MariaDBProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        //[Route("Rate")]
        //[HttpGet]
        //public ActionResult Get(
        //    [FromQuery] string ProductId, 
        //    [FromQuery] int Rating)
        //{
        //    ProductService.AddRating(ProductId, Rating);
        //    return Ok();
        //}
    }
}
