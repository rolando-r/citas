using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuario");

        builder.HasKey(p => p.UsuId);
        builder.Property(p => p.UsuId)
        .ValueGeneratedNever();

        builder.Property(p => p.UsuNombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.UsuSegdoNombre)
        .IsRequired()
        .HasMaxLength(45);

        builder.Property(p => p.UsuPrimerApellidoUsuar)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.UsuSegdoApellidoUsuar)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.UsuTelefono)
        .IsRequired()
        .HasMaxLength(50);

        builder.Property(p => p.UsuDireccion)
        .IsRequired()
        .HasMaxLength(100);

        builder.Property(p => p.UsuEmail)
        .IsRequired()
        .HasMaxLength(100);

        builder.HasOne(p => p.TipoDocumento)
        .WithMany(e => e.Usuarios)
        .HasForeignKey(i => i.UsuTipoDoc);

        builder.HasOne(p => p.Genero)
        .WithMany(e => e.Usuarios)
        .HasForeignKey(i => i.UsuGenero);

        builder.HasOne(p => p.Acudiente)
        .WithMany(e => e.Usuarios)
        .HasForeignKey(i => i.UsuAcudiente);
    }
}