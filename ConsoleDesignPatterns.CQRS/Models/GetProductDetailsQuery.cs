namespace ConsoleDesignPatterns.CQRS.Query
{
    // A request to get data
    public class GetProductDetailsQuery
    {
        public Guid ProductId { get; set; }
    }

}
