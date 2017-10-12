using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaboratoryWork2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Минимальная длина 3!")]
        public string Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Минимальная длина 2!")]
        public string City { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Минимальная длина 2!")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Введите Email.")]
        [EmailAddress(ErrorMessage = "Неверно введенный Email.")]
        public string Email { get; set; }


        public System.DateTime Date { get; set; }
    }
}
