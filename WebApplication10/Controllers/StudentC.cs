using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebApplication10.Models;

namespace WebApplication10.Controllers
{
    public class StudentC : Controller
    {
        public int StudentId { get; private set; }
        public string? Name { get; private set; }
        public DateTime EnrollmentDate { get; private set; }

        public IActionResult Index()
        {

           
            var students = new List<Student>
            {
                new Student { StudentId = 1, Name = "John Smith", EnrollmentDate = DateTime.Now },
                new Student { StudentId = 2, Name = "Joey Tribbiani", EnrollmentDate = DateTime.Now }
            };

            return View(students);
        }
    }
}
