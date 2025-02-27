using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment02.Models
{
    internal class Student
    {


        [Key]
        public int StuId { get; set; }

        [Required]
        [MaxLength(30)]
        public string FName { get; set; }

        [Required]
        [MaxLength(30)]
        public string LName { get; set; }

        [MaxLength(50)]
        public string? Address { get; set; }

        [Range(15, 50)]
        public int Age { get; set; }
        public int Dep_Id { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }
}
