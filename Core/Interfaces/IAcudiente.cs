using System.Linq.Expressions;
using Core.Entities;

namespace Core.Interfaces;
public interface IAcudiente
{
    Task<Acudiente> GetByIdAsync(string id);
    Task<IEnumerable<Acudiente>> GetAllAsync();
    IEnumerable<Acudiente> Find(Expression<Func<ParameterizedThreadStart,bool>> expression);
    void Add(Acudiente entity);
    void AddRange(IEnumerable<Acudiente> entities);
    void Remove(Acudiente entity);
    void RemoveRange(IEnumerable<Acudiente> entities);
    void Update(Acudiente entity);
}