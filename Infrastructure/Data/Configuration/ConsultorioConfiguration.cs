using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class ConsultorioConfiguration : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
        builder.ToTable("Consultorios");

        builder.HasKey(p => p.ConsCodigo);
        builder.Property(p => p.ConsCodigo)
        .ValueGeneratedNever();

        builder.Property(p => p.ConsNombre)
        .IsRequired()
        .HasMaxLength(50);
    }
}