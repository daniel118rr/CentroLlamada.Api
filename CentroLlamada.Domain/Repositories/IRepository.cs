using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CentroLlamada.Domain.DomainService.Repositories
{
    public interface IRepository<TEntity, TId> 
        where TEntity : Entity<TId>, new() 
        where TId : IComparable, IComparable<TId>
    {
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Insert(TEntity entity);

        Task<TEntity> UpdateAsync(TEntity entity);
        TEntity Update(TEntity entity);

        Task<bool> DeleteAsync(TEntity entity);
        bool Delete(TEntity entity);

        Task<bool> DeleteByIdAsync(TId id);
        bool DeleteById(TId id);

        Task<TEntity> FindByIdAsync(TId id);
        TEntity FindById(TId id);

        Task<IEnumerable<TEntity>> FindAllAsync();
        IEnumerable<TEntity> FindAll();

        Task<IEnumerable<TEntity>> FindByExpressionAsync(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> FindByExpression(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate);

    }
}
