using Microsoft.EntityFrameworkCore;
using StudentMVCApplication.Models;

namespace StudentMVCApplication.Repogitory
{
    public class CollectionContext:DbContext
    {
       public DbSet<Student>students {  get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"server=localhost;port=3306;user=root; password=root123;database=aspdotnet";

            //base.OnConfiguring(conString);
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity => {
                entity.HasKey(e => e.SID);
                entity.Property(e => e.Name);
                entity.Property(e => e.Address);
                entity.Property(e => e.MobileNo);
                entity.Property(e => e.Fees);
                entity.Property(e => e.AdmissionDate);
                entity.Property(e => e.Email);
            });


            modelBuilder.Entity<Student>().ToTable("student");
        }



    }
}
