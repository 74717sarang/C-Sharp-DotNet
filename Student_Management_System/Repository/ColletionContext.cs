using Microsoft.EntityFrameworkCore;
using Para.Models;

namespace Para.Repository
{
    public class ColletionContext:DbContext
    {
        public DbSet<Student> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string constring = @"server=localhost;port=;user=;password=;database=";
            optionsBuilder.UseMySQL(constring);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.SID);
                entity.Property(e => e.Name);
                entity.Property(e => e.Address);
                entity.Property(e => e.MobileNo);
                entity.Property(e => e.Status);
                entity.Property(e => e.Fees);
                entity.Property(e => e.AdmissionDate);
                entity.Property(e => e.Email);


            });
            modelBuilder.Entity<Student>().ToTable("student");
        }

    }
}
