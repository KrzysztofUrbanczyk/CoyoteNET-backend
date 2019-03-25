using DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        private readonly Context db;
        public UnitTest1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseInMemoryDatabase("database");
            db = new Context(optionsBuilder.Options);
        }
        [Fact]
        public async Task Test1()
        {
            Assert.Empty(await db.Users.ToListAsync());
        }
    }
}
