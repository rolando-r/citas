using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class TipoDocumento
{
    [Key]
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de TipoDocumentos
    // Definicion de los atributos de la entidad de TipoDocumentos

    public int TipDocId { get; set; }
    public string ? TipDocNombre { get; set; }
    public string ? TipDocAbreviatura { get; set; }

    // Definimos ICollection a las tablas que se relacionan

    public ICollection<Usuario> ? Usuarios { get; set; }
}