using Microsoft.AspNetCore.Mvc;
using AuctionAPI.Models;
using AuctionAPI.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace AuctionAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly AuctionDbContext _context;
        private readonly IHubContext<BidHub> _hubContext;

        public ProductsController(AuctionDbContext context, IHubContext<BidHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }

        // PUT: api/products/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            if (id != updatedProduct.Id)
            {
                return BadRequest("Product ID mismatch");
            }

            var existingProduct = _context.Products.Find(id);
            if (existingProduct == null)
            {
                return NotFound("Product not found");
            }

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Description = updatedProduct.Description;
            existingProduct.StartingPrice = updatedProduct.StartingPrice;
            existingProduct.ImageFileName = updatedProduct.ImageFileName;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE: api/products/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound("Product not found");
            }

            _context.Products.Remove(product);
            _context.SaveChanges();
            return NoContent();
        }

        // PUT: api/products/{id}/bid
        [HttpPut("{id}/bid")]
        public async Task<IActionResult> PlaceBid(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound("Product not found");
            }

            var bidAmount = Math.Max(1m, product.StartingPrice * 0.1m);

            if (product.CurrentPrice == 0)
            {
                product.CurrentPrice = product.StartingPrice + bidAmount;
            }
            else
            {
                product.CurrentPrice += bidAmount;
            }

            _context.SaveChanges();

            //Broadcast to all connected clients
            await _hubContext.Clients.All.SendAsync("BidPlaced");

            return Ok(product);
        }
    }
}


