using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    DepartmentsName = "Science",
                    TotalNumber = 100
                },
                 new Department
                 {
                     DepartmentId = 2,
                     DepartmentsName = "Law",
                     TotalNumber = 200
                 },
                  new Department
                  {
                      DepartmentId = 3,
                      DepartmentsName = "Finance",
                      TotalNumber = 150
                  }
                );

            modelBuilder.Entity<Student>().HasData(
                 new Student
                 {
                     StudentId = 1,
                     Name = "Mark",
                     Age = 20,
                     DepartmentId = 1
                 },

                 new Student
                 {
                     StudentId = 2,
                     Name = "Tom",
                     Age = 22,
                     DepartmentId = 2
                 },

                 new Student
                 {
                     StudentId = 3,
                     Name = "Ana",
                     Age = 23,
                     DepartmentId = 2
                 },

                 new Student
                 {
                     StudentId = 4,
                     Name = "Ben",
                     Age = 21,
                     DepartmentId = 3
                 },

                 new Student
                 {
                     StudentId = 5,
                     Name = "John",
                     Age = 24,
                     DepartmentId = 1
                 }
                 );

        }
                
               
               
        }
    }
