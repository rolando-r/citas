using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class TipoDocumentoConfiguration : IEntityTypeConfiguration<TipoDocumento>
{
    public void Configure(EntityTypeBuilder<TipoDocumento> builder)
    {
        builder.ToTable("TipoDocumento");

        builder.HasKey(p => p.TipDocId);
        builder.Property(p => p.TipDocId)
        .ValueGeneratedNever();

        builder.Property(p => p.TipDocNombre)
        .IsRequired()
        .HasMaxLength(20);

        builder.Property(p => p.TipDocAbreviatura)
        .IsRequired()
        .HasMaxLength(20);
    }
}