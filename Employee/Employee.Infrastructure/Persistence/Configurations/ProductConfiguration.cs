using Employee.Model;
using Employee.Shared.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Persistence.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Products>
{
    public void Configure(EntityTypeBuilder<Products> builder)
    {
        builder.ToTable("Product", schema: "Emp");
        builder.HasKey(x => x.Id);
        builder.HasIndex(x => x.ProductName);
        builder.HasOne(x => x.Countries).WithMany(x => x.Products).HasForeignKey(x => x.CountryId);
        builder.HasData(new
        {
            Id = 1,
            ProductName = "sjchka",
            Description = "adlkcl",
            CountryId = 1,
            Rating = 7.5,
            price = 90.0,
            SellPrice = 30.0,
            BarCode = "wkefhlw",
            ImagePath = "",
            CreatedBy = "1",
            Created = DateTimeOffset.Now,
            LastModified=DateTimeOffset.Now,
            Status = EntityStatus.Created
        });
    }
}
