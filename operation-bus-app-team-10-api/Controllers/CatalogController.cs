using Microsoft.AspNetCore.Mvc;
using Emerald.Tiger.Domain.Catalog;
using Emerald.Tiger.Data;
using Jet.Piranha.Domain.Catalog;

namespace Jet.Piranha.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok(_db.Items);
            }
        private readonly StoreContext_db;

        public CatalogController(StoreContext db)
        {
            _db = db;
            }
        public IActionResult GetItems()
        {
            var items = new List<Item>()
            {
                new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m),
                new Item("Shorts", "Ohio State shorts.", "Nike", 44.99m)
            };

            return Ok(items);
        }

        [HttpGet("{id:int}")]

        public class Rating
        {
            public int Id { get; set; }
            public int Star { get; set; }
            }
        public IActionResult GetItem(int id)
        {
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.Id = id;

            return Ok(item);
        }

        [HttpPost]
        public IActionResult Post(Item item)
        {
            return Created("/catalog/42", item);
        }
        
        [HttpPost("{id:int}/ratings")]
        public IActionResult PostRating(int id, [FromBody] Rating rating)
        {
            var item = new Item("Shirt", "Ohio State shirt.", "Nike", 29.99m);
            item.Id = id;
            item.AddRating(rating);

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public IActionResult Put(int id, Item item)
        {
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        [Authorize("delete:catalog")]
        DELETE https://localhost:7250/catalog/3

        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
