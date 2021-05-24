using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly StudentDbContext context;

        public SQLStudentRepository(StudentDbContext context)
        {
            this.context = context;
        }
        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return student;
        }

        public Student Delete(int Id)
        {
          Student student=  context.Students.Find(Id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return context.Students;
        }

        public Student GetStudent(int id)
        {
           return context.Students.Find(id);
        }

        public Student Update(Student studentChanges)
        {
          var student = context.Students.Attach(studentChanges);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return studentChanges;

        }
    }
}
