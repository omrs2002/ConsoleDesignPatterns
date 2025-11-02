namespace ConsoleDesignPatterns.CQRS.Commands
{
    // --- 3. COMMANDS AND QUERIES ---

    // A request to change data
    public class UpdateProductPriceCommand
    {
        public Guid ProductId { get; set; }
        public decimal NewPrice { get; set; }
    }

}
