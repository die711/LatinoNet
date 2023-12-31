﻿using LatinoNet.Entities.POCOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace LatinoNet.RepositoryEFCore.DataContext
{
    public class LatinoNetContext : DbContext
    {
        public LatinoNetContext(DbContextOptions<LatinoNetContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }
}