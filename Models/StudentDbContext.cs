using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions <StudentDbContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
