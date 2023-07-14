using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository;
public class AcudienteRepository : IAcudiente
{
    private readonly CitasContext _context;
    
    public AcudienteRepository(CitasContext context)
    {
      _context = context;
    }

    public virtual void Add(Acudiente entity)
    {
        _context.Set<Acudiente>().Add(entity);
    }

    public virtual void AddRange(IEnumerable<Acudiente> entities)
    {
        _context.Set<Acudiente>().AddRange(entities);
    }

    public IEnumerable<Acudiente> Find(Expression<Func<Acudiente, bool>> expression)
    {
        return _context.Set<Acudiente>().Where(expression);
    }
}