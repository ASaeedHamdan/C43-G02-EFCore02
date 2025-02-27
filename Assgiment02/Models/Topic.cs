using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgiment02.Models
{
    internal class Topic
    {
        [Key]
        public int TopicId { get; set; }

        [Required]
        [MaxLength(300)]
        public string? Name { get; set; }

        public ICollection<Course> course { get; set; } = new HashSet<Course>();
    }
}
