using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wcanaam.CleanArchitectureBasic.Domain.Entities;

namespace Wcanaam.CleanArchitectureBasic.Infra.Data.EntitiesConfiguration {
    public class CategoryConfiguration : IEntityTypeConfiguration<Category> {

        public void Configure(EntityTypeBuilder<Category> builder) {

            builder.HasKey(t => t.Id);

            builder.Property(p => p.Name)
                .HasMaxLength(50) 
                .IsRequired();

            builder.HasData(
                new Category(1, "Electronics"),
                new Category(2, "Accessories"),
                new Category(3, "Candy")
                );
        }
    }
}
