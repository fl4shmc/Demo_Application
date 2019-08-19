using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DemoApplication.Entities.Entities
{
    public class Program : EntityBase
    {
        [Required]
        public string ProgramName { get; set; }
        public string Category { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
