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
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
