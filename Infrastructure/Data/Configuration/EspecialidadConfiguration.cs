using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
        builder.ToTable("Especialidad");

        builder.Property(p => p.EspId)
        .IsRequired();

        builder.Property(p => p.EspNombre)
        .IsRequired()
        .HasMaxLength(20);
    }
}