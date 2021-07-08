using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;

namespace Wcanaam.CleanArchitectureBasic.Infra.Data.EntitiesConfiguration {
    class ProductConfiguration : IEntityTypeConfiguration<Product> {

        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.HasKey(t => t.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(150);

            builder.Property(p => p.Price)
                .HasPrecision(10,2)
                .IsRequired();


            builder.HasOne(r => r.Category)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId); 
             

        }
    }
}
