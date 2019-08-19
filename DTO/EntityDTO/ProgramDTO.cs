using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO.EntityDTO
{
    public class ProgramDTO
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ProgramName { get; set; }

        public string Category { get; set; }
    }
}
