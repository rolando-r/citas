using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;
public class AcudienteRepository : IAcudiente
{

    protected readonly CitasContext _context;
    
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

    public async Task<IEnumerable<Acudiente>> GetAllAsync()
    {
        return await _context.Set<Acudiente>().ToListAsync();
    }

    public async Task<Acudiente> GetByIdAsync(string id)
    {
        return await _context.Set<Acudiente>().FindAsync(id);
    }

    public void Remove(Acudiente entity)
    {
        _context.Set<Acudiente>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Acudiente> entities)
    {
        _context.Set<Acudiente>().RemoveRange(entities);
    }

    public void Update (Acudiente entity)
    {
        _context.Set<Acudiente>().Update(entity);
    }
}