using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment02.Models
{
    internal class Department
    {
        [Key]
        public int DeptId { get; set; }

        [Required]
        [MaxLength(30)]
        [MinLength(30)]
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }


        //navigation property that represents a relationship between Department and Student.
        public Student Student { get; set; } = null!;
        // Foreign key for Manager (Instructor)
        [ForeignKey(nameof(Manager))]
        public int ManagerId { get; set; }

        // Navigation property for Manager (Instructor)
        [InverseProperty(nameof(Instructor.ManagedDepartment))]
        public Instructor Manager { get; set; } = null!;

        // Navigation property for Instructors (one-to-many)
        [InverseProperty(nameof(Instructor.HiredDepartment))]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

    }
}
