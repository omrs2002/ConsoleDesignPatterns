using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns.CQRS.Models
{
    // --- 1. MODELS ---

    /// <summary>
    /// This is our "Write Model" or "Domain Model". 
    /// It contains business logic.
    /// </summary>
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }

        // Private constructor to enforce creation through a factory or handler
        private Product(Guid id, string name, decimal price, int stock)
        {
            Id = id;
            Name = name;
            Price = price;
            Stock = stock;
        }

        // Factory method
        public static Product Create(string name, decimal price, int stock)
        {
            return new Product(Guid.NewGuid(), name, price, stock);
        }

        // Business logic lives here
        public void ChangePrice(decimal newPrice)
        {
            if (newPrice < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }
            Price = newPrice;
        }
    }

}
