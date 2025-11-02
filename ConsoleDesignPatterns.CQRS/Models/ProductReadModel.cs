namespace ConsoleDesignPatterns.CQRS.Models
{
    /// <summary>
    /// This is our "Read Model" or "DTO". 
    /// It's flat and optimized for display.
    /// </summary>
    public class ProductReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PriceDisplay { get; set; } // e.g., formatted for the UI
    }

}
