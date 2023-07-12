using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ConsultorioConfiguration : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
        builder.ToTable("Consultorios");

        builder.Property(p => p.ConsCodigo)
        .IsRequired();

        builder.Property(p => p.ConsNombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}