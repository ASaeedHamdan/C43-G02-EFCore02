using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment02.Models
{
    internal class Course_Inst
    {
        [Key]
        [Column(Order = 0)]
        public int inst_ID { get; set; }

        [Column(Order = 1)]
        public int Course_ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string evaluate { get; set; }
    }
}
