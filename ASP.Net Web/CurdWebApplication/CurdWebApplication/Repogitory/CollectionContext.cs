//using Crud.Models;
//using Microsoft.EntityFrameworkCore;

//namespace Crud.Connection
//{
//    public class CollectionContext:DbContext
//    {
//        public DbSet<Employee> employee { get; set; }


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            string conString = @"server=localhost;port=3306;user=root; password=root123;database= zest_dotNet";
//            optionsBuilder.UseMySQL(conString);
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            base.OnModelCreating(modelBuilder);
//            modelBuilder.Entity<Employee>(entity =>
//            {
//                entity.HasKey(e => e.Id);
//                entity.Property(e => e.Name);
//                entity.Property(e => e.Role);
//                entity.Property(e => e.Designation);
//              //  entity.Property(e => e.Eamil);





//            });
//            modelBuilder.Entity<Employee>().ToTable("Employee");


//    }


//}
//}
using CurdWebApplication.Auth;
using CurdWebApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace CurdWebApplication.Connection
{
    public class CollectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    string conString = "server=localhost;port=3306;user=root;password=root123;database=zest_dotNet";
        //    optionsBuilder.UseMySQL(conString);
        //}

        public CollectionContext(DbContextOptions<CollectionContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder) { 
            modelBuilder.Entity<Employee>().ToTable("Employee");
        modelBuilder.Entity<User>().ToTable("user");
    }


    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.Entity<Employee>().ToTable("Employee");
    //    modelBuilder.Entity<User>().ToTable("user");
    //}



}
}
