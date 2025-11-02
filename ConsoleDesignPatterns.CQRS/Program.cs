using ConsoleDesignPatterns.CQRS.Commands;
using ConsoleDesignPatterns.CQRS.Handlers;
using ConsoleDesignPatterns.CQRS.Models;
using ConsoleDesignPatterns.CQRS.Query;

namespace ConsoleDesignPatterns.CQRS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, CQRS!");
            // --- Setup ---
            var commandHandler = new ProductCommandHandler();
            var queryHandler = new ProductQueryHandler();

            // 1. Create a new product and seed both databases
            var newProduct = Product.Create("Laptop", 1200.00m, 50);

            // Add to write DB
            WriteDatabase.Products.Add(newProduct.Id, newProduct);

            // Add to read DB
            ReadDatabase.ProductViews.Add(newProduct.Id, new ProductReadModel
            {
                Id = newProduct.Id,
                Name = newProduct.Name,
                PriceDisplay = $"${newProduct.Price:F2}"
            });

            Console.WriteLine("--- System Initialized ---");

            // --- 1. Read the product (QUERY) ---
            Console.WriteLine("\n--- First Query ---");
            var query = new GetProductDetailsQuery { ProductId = newProduct.Id };
            var productView = queryHandler.Handle(query);
            Console.WriteLine($"Query Result: {productView.Name} is {productView.PriceDisplay}");

            // --- 2. Update the product's price (COMMAND) ---
            Console.WriteLine("\n--- Sending Command ---");
            var command = new UpdateProductPriceCommand
            {
                ProductId = newProduct.Id,
                NewPrice = 999.99m
            };
            commandHandler.Handle(command);

            // --- 3. Read the product again (QUERY) ---
            Console.WriteLine("\n--- Second Query ---");
            var updatedQuery = new GetProductDetailsQuery { ProductId = newProduct.Id };
            var updatedView = queryHandler.Handle(updatedQuery);
            Console.WriteLine($"Query Result: {updatedView.Name} is now {updatedView.PriceDisplay}");

        }
    }
}
