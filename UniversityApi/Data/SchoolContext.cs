using Microsoft.EntityFrameworkCore;
using UniversityApi.Models;

namespace UniversityApi.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses{ get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
               modelBuilder.Entity<Student>().ToTable("Student");
               modelBuilder.Entity<Course>().ToTable("Courses");
        }
    }
}