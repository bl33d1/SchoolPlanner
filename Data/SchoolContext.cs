using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolPlanner.Models;

namespace SchoolPlanner.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext (DbContextOptions<SchoolContext> options)
            : base(options)
        {
        }

        public DbSet<SchoolPlanner.Models.Subject> Subjects { get; set; }

        public DbSet<SchoolPlanner.Models.Exam> Exams { get; set; }

        public DbSet<SchoolPlanner.Models.Task> Tasks { get; set; }

        public DbSet<SchoolPlanner.Models.Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subject>().ToTable("Subject");
            modelBuilder.Entity<Exam>().ToTable("Exam");
            modelBuilder.Entity<SchoolPlanner.Models.Task>().ToTable("Task");
            modelBuilder.Entity<SchoolPlanner.Models.Teacher>().ToTable("Teacher");
        }
    }
}
