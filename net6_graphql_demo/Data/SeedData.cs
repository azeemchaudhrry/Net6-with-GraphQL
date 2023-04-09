using Microsoft.EntityFrameworkCore;
using net6_graphql_demo.Entities;

namespace net6_graphql_demo.Data; 

public class SeedData 
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new DbContextClass(
            serviceProvider.GetRequiredService<DbContextOptions<DbContextClass>>()))
        {
            if (context.Products.Any())
            {
                return;
            }
            context.Products.AddRange(
                new ProductDetails
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Lenovo",
                    ProductDescription = "ThinkPad P50",
                    ProductPrice = 1200,
                    ProductStock = 10
                },
                new ProductDetails
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Lenovo",
                    ProductDescription = "ThinkPad P51",
                    ProductPrice = 1500,
                    ProductStock = 5
                });
            context.SaveChanges();
        }
    }
}
