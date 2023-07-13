using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;
public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
{
    public void Configure(EntityTypeBuilder<Medico> builder)
    {
        builder.ToTable("Medico");

        builder.HasKey(p => p.MedNroMatriculaProfesional);
        builder.Property(p => p.MedNroMatriculaProfesional)
        .ValueGeneratedNever();

        builder.Property(p => p.MedNombreCompleto)
        .IsRequired()
        .HasMaxLength(120);

        builder.HasOne(p => p.Consultorio)
        .WithMany(e => e.Medicos)
        .HasForeignKey(i => i.MedConsultorio);

        builder.HasOne(p => p.Especialidad)
        .WithMany(e => e.Medicos)
        .HasForeignKey(i => i.MedEspecialidad);
    }
}