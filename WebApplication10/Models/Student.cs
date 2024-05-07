using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please enter the student's name.")]
        public string ? Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
    }
}
