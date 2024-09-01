using Microsoft.AspNetCore.Mvc;
using Shared.Models;

namespace Carrito.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Title = "Producto 1", Description = "Descripción del Producto 1", Price = 19.99m, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 2, Title = "Producto 2", Description = "Descripción del Producto 2", Price = 29.99m, ImageUrl = "https://via.placeholder.com/150" },
            new Product { Id = 3, Title = "Producto 3", Description = "Descripción del Producto 3", Price = 39.99m, ImageUrl = "https://via.placeholder.com/150" },
            // Agrega más productos según necesites
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
