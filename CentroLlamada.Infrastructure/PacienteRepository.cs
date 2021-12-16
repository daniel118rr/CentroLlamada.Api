using CentroLlamada.Domain;
using CentroLlamada.Domain.DomainService;
using CentroLlamada.Domain.DomainService.Repositories;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CentroLlamada.Infrastructure
{
    public class PacienteRepository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : class, new()
        where TId : IComparable, IComparable<TId>
    {
        private readonly IMongoCollection<TEntity> mongoCollection;

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity DeleteById(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> DeleteByIdAsyn(TId id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> FindByExpression(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> FindByExpressionAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity FindById(TId id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindByIdAsync(TId id)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
