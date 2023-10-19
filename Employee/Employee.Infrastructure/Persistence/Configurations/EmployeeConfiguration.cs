using Microsoft.EntityFrameworkCore;
using Employee.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Net;
using Employee.Shared.Enums;

namespace Employee.Infrastructure.Persistence.Configurationsl;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employees>
{
    public void Configure(EntityTypeBuilder<Employees> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasOne(x => x.Country).WithMany(x=> x.Employees).HasForeignKey(x => x.CountryId);
        builder.HasOne(x => x.State).WithMany(x=> x.Employee).HasForeignKey(x=> x.StateId);
        
    }
}
