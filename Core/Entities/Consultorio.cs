using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Consultorio
{
    [Key]
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de Consultorios
    // Definicion de los atributos de la entidad de Consultorios

    public int ConsCodigo { get; set; }
    public string ? ConsNombre { get; set; }

    // Definimos los ICollection a las tablas que se relacionan 

    public ICollection<Medico> ? Medicos { get; set; }
}