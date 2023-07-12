using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class EstadoCita
{
    [Key]
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de EstadoCitas
    // Definicion de los atributos de la entidad de EstadoCitas

    public int EstCitaId { get; set; }
    public string ? EstCitaNombre { get; set; }

    // Definimos los ICollection a las tablas que se relacionan

    public ICollection<Cita> ? Citas { get; set; }

}