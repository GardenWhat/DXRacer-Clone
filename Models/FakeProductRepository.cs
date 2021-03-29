using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class FakeProductRepository /*: IProductRepository*/
    {
        public IEnumerable<Product> Products => new List<Product> {
            new Product { ProductID = 1, Name = "Football", Description = "A ball that you can throw or kick.", Price = 25, Category = "Field Sports" },
            new Product { ProductID = 2, Name = "Surf board", Description = "A board that you can surf on.", Price = 179, Category = "Water Sports" },
            new Product { ProductID = 3, Name = "Running shoes", Description = "Shoes that you can go running in.", Price = 95, Category = "Track and Field" },
            new Product { ProductID = 4, Name = "Tennis Ball", Description = "Tennis Ball to play tennis with. Can also be used for bouncing and stuff.", Price = 5, Category = "Tennis" }
        };
    }
}