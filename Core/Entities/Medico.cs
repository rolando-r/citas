using System.ComponentModel.DataAnnotations;

namespace Core.Entities;
public class Medico
{
    [Key]
    // Entidad Hija_padre
    // Realizamos la referencia de la entidad de Medicos
    // Definicion de los atributos de la entidad de Medicos

    public int MedNroMatriculaProfesional { get; set; }
    public string ? MedNombreCompleto { get; set; }
    public int MedConsultorio { get; set; }
    public Consultorio ? Consultorio { get; set; }
    public int MedEspecialidad { get; set; }
    public Especialidad ? Especialidad { get; set; }

    // Definimos los ICollection a las tablas que se relacionan

    public ICollection<Cita> ? Citas { get; set; }
}