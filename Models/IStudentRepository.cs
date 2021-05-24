using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
 public interface IStudentRepository
    {
        //which operations are supported
        Student GetStudent(int id);
        IEnumerable<Student> GetAllStudents();
        Student Add(Student student);
        Student Update(Student studentChanges);
        Student Delete(int Id);
    }
}
