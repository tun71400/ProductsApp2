using ProductsApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ProductsApp2.Controllers
{
    public class ProductsController : ApiController
    {

        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Chicken Soup", Category = "Food", Price = 5 },
            new Product { Id = 2, Name = "Pencil", Category = "Office Supply", Price = 10 },
            new Product { Id = 3, Name = "Elden Ring", Category = "Game", Price = 15 }
        };

        public ProductsController()
        {

        }
        public ProductsController(Product[] products)
        {
            this.products = products;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
