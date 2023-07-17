using System.Linq.Expressions;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class ConsultorioRepository : IConsultorio
{
    protected readonly CitasContext _context;
    
    public ConsultorioRepository(CitasContext context)
    {
      _context = context;
    }

    public void Add(Consultorio entity)
    {
        _context.Set<Consultorio>().Add(entity);
    }

    public void AddRange(IEnumerable<Consultorio> entities)
    {
        _context.Set<Consultorio>().AddRange(entities);
    }

    public IEnumerable<Consultorio> Find(Expression<Func<Consultorio, bool>> expression)
    {
        return _context.Set<Consultorio>().Where(expression);
    }

    public IEnumerable<Consultorio> Find(Expression<Func<ParameterizedThreadStart, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Consultorio>> GetAllAsync()
    {
        return await _context.Set<Consultorio>().ToListAsync();
    }

    public async Task<Consultorio> GetByIdAsync(string id)
    {
        return await _context.Set<Consultorio>().FindAsync(id);
    }

    public void Remove(Consultorio entity)
    {
        _context.Set<Consultorio>().Remove(entity);
    }

    public void RemoveRange(IEnumerable<Consultorio> entities)
    {
        _context.Set<Consultorio>().RemoveRange(entities);
    }

    public void Update(Consultorio entity)
    {
        _context.Set<Consultorio>().Update(entity);
    }

}