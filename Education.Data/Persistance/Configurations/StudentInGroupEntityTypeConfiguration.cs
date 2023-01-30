using Education.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Data.Persistance.Configurations
{
    public class StudentInGroupEntityTypeConfiguration : IEntityTypeConfiguration<StudentInGroup>
    {
        public void Configure(EntityTypeBuilder<StudentInGroup> builder)
        {
           builder.HasKey(t => t.Id);

            builder.HasOne(x => x.Student)
                 .WithMany(x => x.StudentInGroups)
                 .HasForeignKey(x => x.StudentId);

            builder.HasOne(x => x.Group)
                .WithMany(x => x.StudentInGroups)
                .HasForeignKey(x => x.GroupId);
        } 
    }
}
