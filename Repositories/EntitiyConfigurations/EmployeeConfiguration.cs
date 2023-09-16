using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntitiyConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasIndex(e => e.LastName, "LastName");
            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            builder.Property(e => e.FirstName).HasColumnName("FirstName");
            builder.Property(e => e.LastName).HasColumnName("LastName");
            builder.Property(e => e.Title).HasColumnName("Title");
        }
    }
}
