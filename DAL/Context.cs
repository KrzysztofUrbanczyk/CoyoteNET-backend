using System;
using Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore.Design;

namespace DAL
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions options) : base(options)
        {

        }
    }
}
