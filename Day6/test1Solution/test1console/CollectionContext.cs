using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1console
{
    internal class CollectionContext: DbContext
    {
        public CollectionContext() { }
        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options)
        {
        }

        public DbSet<department> Departments { get; set; }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "server=localhost;database=your_db_name;user=your_username;password=your_password;";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            }
        }

    }

