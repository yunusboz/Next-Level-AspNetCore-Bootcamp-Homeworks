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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(e => e.OrderId).HasColumnName("OrderID");
            builder.HasIndex(e => e.EmployeeId, "EmployeeID");
            builder.HasIndex(e => e.EmployeeId, "EmployeesOrders");
            builder.HasIndex(e => e.OrderDate, "OrderDate");
            builder.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

            builder.Property(e => e.OrderDate).HasColumnType("datetime");
            builder.Property(e => e.ShipCountry).HasMaxLength(15);

            builder.HasOne(d => d.Employee).WithMany(p => p.Orders)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK_Orders_Employees");

        }
    }
}
