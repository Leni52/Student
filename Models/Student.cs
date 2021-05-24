using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Models
{
    public class Student
    {
      
        public int StudentId { get; set; }
      
        [Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        
        

        
    }
}
