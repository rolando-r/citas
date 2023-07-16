using System.Linq.Expressions;
using Core.Entities;
namespace Core.Interfaces;
public interface IConsultorio
{
    Task<Consultorio> GetByIdAsync(string id);
    Task<IEnumerable<Consultorio>> GetAllAsync();
    IEnumerable<Consultorio> Find(Expression<Func<ParameterizedThreadStart,bool>> expression);
    void Add(Consultorio entity);
    void AddRange(IEnumerable<Consultorio> entities);
    void Remove(Consultorio entity);
    void RemoveRange(IEnumerable<Consultorio> entities);
    void Update(Consultorio entity);
}