using DemoApplication.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Student : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Program { get; set; }
        [Required]
        public int TeacherId { get; set; }
        [Required]
        public int ProgramId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Program Programm { get; set; } 
    }
}
