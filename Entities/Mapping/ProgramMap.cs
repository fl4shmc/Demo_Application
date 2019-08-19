using DemoApplication.Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication.Entities.Mapping
{
    public class ProgramMap : IEntityTypeConfiguration<Program>
    {
        public void Configure(EntityTypeBuilder<Program> builder)
        {
            builder.HasMany(s => s.Students).WithOne(p => p.Programm).HasForeignKey(s => s.ProgramId);
        }
    }
}
