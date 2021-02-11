using CodingTest.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTest.Data
{
    public class CodingTestDbContext : DbContext
    {
        public CodingTestDbContext(DbContextOptions options) : base (options)
        {
        }

        public DbSet<Subscription> Subscriptions { get; set; }
    }
}
