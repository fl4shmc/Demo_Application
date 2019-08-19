using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication.Entities.Mapping
{
    public class EntityBaseMap : IEntityTypeConfiguration<EntityBase>
    {
        public void Configure(EntityTypeBuilder<EntityBase> builder)
        {
            builder.Property<DateTime>("CreatedTime");
            builder.Property<DateTime>("CreatedDate");
        }
    }
}
