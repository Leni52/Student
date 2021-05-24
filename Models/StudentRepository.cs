using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    //implementation of IStudentRepository
    //Stores and retrieves objects from In Memory Repository
    public class StudentRepository : IStudentRepository
    {
        private List<Student> _studentList;
        public Student Add(Student student)
        {
            student.StudentId = _studentList.Max(e => e.StudentId) + 1;
            _studentList.Add(student);
            return student;
        }

        public Student Delete(int Id)
        {
           Student student= _studentList.FirstOrDefault(e => e.StudentId == Id);

            if (student != null)
            {
                _studentList.Remove(student);
            }
            return student;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _studentList;
        }

        public Student GetStudent(int id)
        {
            return _studentList.FirstOrDefault(e => e.StudentId == id);
        }

        public Student Update(Student studentChanges)
        {
            Student student = _studentList.FirstOrDefault(e => e.StudentId == studentChanges.StudentId);

            if (student != null)
            {
                student.Name = studentChanges.Name;
                student.Age = studentChanges.Age;
                student.DepartmentId = studentChanges.DepartmentId;
            }
            return student;
        }
    }
}
