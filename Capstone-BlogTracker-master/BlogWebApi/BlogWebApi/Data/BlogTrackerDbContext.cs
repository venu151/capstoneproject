using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlogWebApi.Data
{
    public class BlogTrackerDbContext : DbContext
    {

        public BlogTrackerDbContext(DbContextOptions<BlogTrackerDbContext> options)
            : base(options)
        {
        }

        public DbSet<BlogWebApi.Models.BlogInfo> BlogInfo { get; set; } = default!;

        public DbSet<BlogWebApi.Models.EmpInfo>? EmpInfo { get; set; }
        public DbSet<BlogWebApi.Models.AdminInfo> AdminInfo { get; set; }
    }
}
