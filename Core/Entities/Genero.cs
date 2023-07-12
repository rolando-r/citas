using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Genero
{
    [Key]
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de Generos
    // Definicion de los atributos de la entidad de Generos

    public int GenId { get; set; }
    public string ? GenNombre { get; set; }
    public string ? GenAbreviatura { get; set; }

    // Definimos ICollection a las tablas que se relacionan

    public ICollection<Usuario> ? Usuarios { get; set; }


}