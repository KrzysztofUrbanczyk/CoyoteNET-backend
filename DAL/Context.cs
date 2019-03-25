namespace DAL
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
