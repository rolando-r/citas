namespace Core.Interfaces;
public interface IUnitOfWork
{
    IAcudiente Acudientes { get; }
    IConsultorio Consultorios { get; }
}