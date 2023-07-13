using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("Genero");

        builder.HasKey(p => p.GenId);
        builder.Property(p => p.GenId)
        .ValueGeneratedNever();

        builder.Property(p=> p.GenNombre)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p=> p.GenAbreviatura)
        .IsRequired()
        .HasMaxLength(20);
    }
}