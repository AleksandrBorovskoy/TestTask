using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestTaskAPI.Models;

namespace TestTaskAPI.Data
{
    public class TestTaskDbContext : DbContext
    {
        public TestTaskDbContext(DbContextOptions<TestTaskDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
