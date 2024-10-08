﻿using getting_started.Models;
using Microsoft.EntityFrameworkCore;

namespace getting_started.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Student> students { get; set; }
        public DbSet<StudentCourse> Enrollment {  get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student_table");
            modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse_table");
            modelBuilder.Entity<Course>().ToTable("Course_table");
        }
    }
}
