using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Files.Configuration
{
    internal class FileConfiguration : IEntityTypeConfiguration<Domain.Files.File>
    {
        public void Configure(EntityTypeBuilder<Domain.Files.File> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasMaxLength(256).IsRequired();
            builder.Property(a => a.ContentType).HasMaxLength(256).IsRequired();
        }
    }
}
