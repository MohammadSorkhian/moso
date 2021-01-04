using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a NAME")]
        [MaxLength(50, ErrorMessage ="Your name is too LONG")]
        [MinLength(5,ErrorMessage ="Your name is too SHORT please enter your full name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an EMAIL")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage ="Please Enter a Valid Email Address")]
        public string Email { get; set; }

        [Required]
        public Department? Department { get; set; }
        public String PhotoPath { get; set; }

    }
}
