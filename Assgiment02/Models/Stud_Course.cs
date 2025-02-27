using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment02.Models
{
    internal class Stud_Course
    {
        [Key]
        [Column(Order = 0)]
        public int stud_ID { get; set; }

        [Column(Order = 1)]
        public int Course_ID { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Grade { get; set; }
    }
}
