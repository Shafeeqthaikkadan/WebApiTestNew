using Microsoft.EntityFrameworkCore;
using WebApiTest.Entities;

namespace WebApiTest.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<State> States { get; set; }
    }
}
