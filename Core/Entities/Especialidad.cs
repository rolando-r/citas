using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Especialidad
{
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de Especialidad
    // Definicion de los atributos de la entidad de Especialidad
    
    public int EspId { get; set; }
    public string ? EspNombre { get; set; }

    // Definimos los ICollection a las tablas que se relacionan

    public ICollection<Medico> ? Medicos { get; set; }
}