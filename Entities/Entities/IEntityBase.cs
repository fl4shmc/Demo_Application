using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    interface IEntityBase
    {
        int Id { get; set; }
        DateTime CreatedTime { get; set; }
        DateTime CreatedDate { get; set; }

    }
}
