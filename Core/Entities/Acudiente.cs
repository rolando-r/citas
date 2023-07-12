using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Acudiente
{
    [Key]
    // Entidad Hija_padre
    //realizamos las referencias de la entidad de Acudiente
    //definicion de los atributos de la entidad Acudiente

    public int AcuCodigo { get; set; }
    public string ? AcuNombre { get; set; }
    public string ? AcuTelefono { get; set; }
    public string ? AcuDireccion { get; set; }

    // Definimos los ICollection a las tablas que se relacionan

    public ICollection<Usuario> ? Usuarios { get; set; }
}