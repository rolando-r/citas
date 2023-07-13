using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Cita
{
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de Citas
    // Definicion de los atributos de la entidad de acudientes

    public int CitCodigo { get; set; }
    public DateTime CitFecha { get; set; }
    public int CitEstado { get; set; }
    public EstadoCita ? EstadoCita { get; set; }
    public int CitMedico { get; set; }
    public Medico ? Medico { get; set; }
    public int CitDatosUsuario { get; set; }
    public Usuario ? Usuario { get; set; }

}