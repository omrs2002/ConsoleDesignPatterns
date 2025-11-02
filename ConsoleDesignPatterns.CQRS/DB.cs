using ConsoleDesignPatterns.CQRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDesignPatterns.CQRS
{
    public static class WriteDatabase
    {
        // Simulates our normalized, transactional database (e.g., SQL Server)
        public static readonly Dictionary<Guid, Product> Products = new();
    }

    public static class ReadDatabase
    {
        // Simulates our denormalized, fast read-store (e.g., Redis cache or a "view" table)
        public static readonly Dictionary<Guid, ProductReadModel> ProductViews = new();
    }

}
