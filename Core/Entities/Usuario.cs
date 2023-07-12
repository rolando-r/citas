using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Usuario
{
    [Key]
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de Usuarios
    // Definicion de los atributos de la entidad de Usuarios

    public int UsuId { get; set; }
    public string ? UsuNombre { get; set; }
    public string ? UsuSegdoNombre { get; set; }
    public string ? UsuPrimerApellidoUsuar { get; set; }
    public string ? UsuSegdoApellidoUsuar { get; set; }
    public string ? UsuTelefono { get; set; }
    public string ? UsuDireccion { get; set; }
    public string ? UsuEmail { get; set; }
    public int UsuTipoDoc { get; set; }
    public TipoDocumento ? TipoDocumento { get; set; }
    public int UsuGenero { get; set; }
    public Genero ? Genero { get; set; }
    public int UsuAcudiente { get; set; }
    public Acudiente ? Acudiente { get; set; }

    // Definimos los ICollection a las tablas que se relacionan

    public ICollection<Cita> ? Citas { get; set; }
    
}