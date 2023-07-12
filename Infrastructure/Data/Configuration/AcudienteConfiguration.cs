using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class AcudienteConfiguration : IEntityTypeConfiguration<Acudiente>
{
    public void Configure(EntityTypeBuilder<Acudiente> builder)
    {
        builder.ToTable("Acudiente");

        builder.Property(p => p.AcuCodigo)
        .IsRequired();

        builder.Property(p => p.AcuNombre)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.AcuTelefono)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.AcuDireccion)
        .IsRequired()
        .HasMaxLength(200);
    }
}