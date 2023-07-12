using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        builder.ToTable("Cita");

        builder.Property(p => p.CitCodigo)
        .IsRequired();

        builder.Property(p => p.CitFecha)
        .IsRequired()
        .HasColumnType("date");

        builder.HasOne(p => p.EstadoCita)
        .WithMany(e => e.Citas)
        .HasForeignKey(i => i.CitEstado);

        builder.HasOne(p => p.Medico)
        .WithMany(e => e.Citas)
        .HasForeignKey(i => i.CitMedico);

        builder.HasOne(p => p.Usuario)
        .WithMany(e => e.Citas)
        .HasForeignKey(i => i.CitDatosUsuario);
    }
}