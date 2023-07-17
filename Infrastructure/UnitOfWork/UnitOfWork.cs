using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly CitasContext context;
    private AcudienteRepository _acudientes;
    private ConsultorioRepository _consultorios;

    public UnitOfWork(CitasContext _context)
    {
        context = _context;
    }

    public IAcudiente Acudientes
    {
        get{
            if(_acudientes == null){
                _acudientes = new AcudienteRepository(context);
            }
            return _acudientes;
        }
    }
    public IConsultorio Consultorios
    {
        get{
            if(_consultorios == null){
                _consultorios = new ConsultorioRepository(context);
            }
            return _consultorios;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }

    public int Save()
    {
        throw new NotImplementedException();
    }
}