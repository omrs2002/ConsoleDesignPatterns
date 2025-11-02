using ConsoleDesignPatterns.CQRS.Models;
using ConsoleDesignPatterns.CQRS.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns.CQRS.Handlers
{

    /// <summary>
    /// Handles all "Read" operations for Products.
    /// </summary>
    public class ProductQueryHandler
    {
        public ProductReadModel Handle(GetProductDetailsQuery query)
        {
            // 1. Get the DTO directly from the READ store.
            // No business logic, no complex joins. Just a fast lookup.
            if (ReadDatabase.ProductViews.TryGetValue(query.ProductId, out var readModel))
            {
                return readModel;
            }

            Console.WriteLine($"ERROR: Product {query.ProductId} not found in read DB.");
            return null;
        }
    }

}
