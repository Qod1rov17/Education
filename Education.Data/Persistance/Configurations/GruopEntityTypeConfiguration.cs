using Education.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data.Persistance.Configurations
{
    public class GruopEntityTypeConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasOne(x => x.Teacher)
                .WithMany(X => X.Groups)
                .HasForeignKey(x => x.TeacherId);
        }
    }
}
