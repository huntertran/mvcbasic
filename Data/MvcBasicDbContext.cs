namespace mvcbasic.Data
{
    using Models;
    using Microsoft.EntityFrameworkCore;

    public class MvcBasicDbContext : DbContext
    {
        public MvcBasicDbContext(DbContextOptions<MvcBasicDbContext> options) : base(options)
        {
        }

        public DbSet<Phone> Phones { get; set; }
    }
}