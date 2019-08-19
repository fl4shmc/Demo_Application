using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO.EntityDTO
{
    public class StudentDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public string Program { get; set; }

        [Required]
        public int TeacherId { get; set; }
    }
}
