using Microsoft.EntityFrameworkCore;    

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbContextOptions<ApplicationDbContext> options;


    }
}
