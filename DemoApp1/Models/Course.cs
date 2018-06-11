using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp1.Models
{
    public class Course
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(200)]
        public string Title { get; set; }

        public int TotalHourse { get; set; }
    }
}
