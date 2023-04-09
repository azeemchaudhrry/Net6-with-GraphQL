using Microsoft.EntityFrameworkCore;
using net6_graphql_demo.Entities;

namespace net6_graphql_demo.Data;

public class DbContextClass : DbContext
{
    public DbContextClass(DbContextOptions<DbContextClass>
options) : base(options)
    {
    }
    public DbSet<ProductDetails> Products { get; set; }
}
