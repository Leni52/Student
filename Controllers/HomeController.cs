using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentProject.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public object HomeDetailsViewModel { get; private set; }

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            var model = _studentRepository.GetAllStudents();
            return View(model);
        }
        
        public ViewResult Details(int? id)
        {
            /*
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Student = _studentRepository.GetStudent(id ?? 1),
                PageTitle = "Student Details"
            };
            return View(homeDetailsViewModel);
            */
            return View();
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                Student newStudent = _studentRepository.Add(student);
            }
            return View();
        }
    }
}
