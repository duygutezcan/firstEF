using firstEF.Data;
using Microsoft.EntityFrameworkCore;

namespace firstEF.Context
{
    public class PerContext:DbContext
    {
        public PerContext()
        {
        }

        public PerContext(DbContextOptions<PerContext> db):base(db)  //base(db) = DbContext
        {
            
        }
       public DbSet<Products> Products { get; set; }
        public DbSet<Categories> Categories { get; set; }
    }
}
