using ConsoleDesignPatterns.CQRS.Commands;

namespace ConsoleDesignPatterns.CQRS.Handlers
{
    // --- 4. HANDLERS ---

    /// <summary>
    /// Handles all "Write" operations for Products.
    /// </summary>
    public class ProductCommandHandler
    {
        public void Handle(UpdateProductPriceCommand command)
        {
            // 1. Get the domain object from the WRITE store
            if (!WriteDatabase.Products.TryGetValue(command.ProductId, out var product))
            {
                Console.WriteLine($"ERROR: Product {command.ProductId} not found in write DB.");
                return;
            }

            // 2. Execute business logic on the domain object
            product.ChangePrice(command.NewPrice);

            // 3. Save the change back to the WRITE store (already in-memory, but simulate save)
            Console.WriteLine($"[WriteDB] Updated Product {product.Id} price to {product.Price}");

            // 4. Update the READ model
            // In a real system, this would be asynchronous (e.g., via a message bus like RabbitMQ)
            // For the console app, we do it synchronously.
            if (ReadDatabase.ProductViews.TryGetValue(command.ProductId, out var readModel))
            {
                readModel.PriceDisplay = $"${product.Price:F2}"; // Format the read model
                Console.WriteLine($"[ReadDB] Updated Product View {readModel.Id} price to {readModel.PriceDisplay}");
            }
        }
    }

}
