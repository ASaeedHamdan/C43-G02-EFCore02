using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment02.Models
{
    internal class Instructor
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(30)]
        [MinLength(30)]
        [Column("InstructorName", TypeName = "varchar")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Salary { get; set; }
        public string? Address { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal HourRate { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Bouns { get; set; }
        public int Dept_ID { get; set; }


        [InverseProperty(nameof(Department.Manager))]
        public Department ManagedDepartment { get; set; } = null!;

        [ForeignKey(nameof(HiredDepartment))]
        public int DeptId { get; set; }
        [InverseProperty(nameof(Department.Instructors))]
        public Department HiredDepartment { get; set; } = null!;
    }
}
