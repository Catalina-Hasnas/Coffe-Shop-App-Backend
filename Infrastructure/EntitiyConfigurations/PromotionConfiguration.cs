using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntitiyConfigurations
{
    class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.HasMany(x => x.Products)
                   .WithOne(x => x.Promotion)
                   .HasForeignKey(x => x.PromotionId);

            builder.Property(x => x.Discount)
                   .HasColumnType("decimal(8, 2)")
                   .IsRequired();
        }
    }
}
