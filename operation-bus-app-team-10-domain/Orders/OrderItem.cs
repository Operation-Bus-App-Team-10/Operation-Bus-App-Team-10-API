using Jet.Piranha.Domain.Catalog;

namespace Jet.Piranha.Domain.Orders
{
    public class OrderItem
    {
        public int id{ get; set;}
        public Item Item{ get; set;}
        public int Quantity { get; set;}
        public decimal Price => Item.Price * Quantity;
    }
     
}