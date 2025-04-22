using System;
using CrudOperations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CrudOperations.Data
{
    public class AppDbContext : DbContext
    {
		
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Products> Products { get; set; }
    
	}
}

