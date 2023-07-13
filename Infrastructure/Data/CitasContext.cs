using System.Reflection;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class CitasContext : DbContext
{
    public CitasContext(DbContextOptions<CitasContext> options) : base(options)
    {
    }
    public DbSet<Acudiente> Acudientes { get; set; }
    public DbSet<Cita> Citas { get; set; }
    public DbSet<Consultorio> Consultorios { get; set; }
    public DbSet<Especialidad> Especialidades { get; set; }
    public DbSet<EstadoCita> EstadoCitas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Medico> Medicos { get; set; }
    public DbSet<TipoDocumento> TipoDocumentos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}