using CentroLlamada.Application.ApplicationService;
using CentroLlamada.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentroLlamada.Api.Controllers
{
    public class BaseController<TEntity, TId> : ControllerBase
        where TEntity : Entity<TId>, new()
        where TId : IComparable, IComparable<TId>
    {
        public readonly ICrudService<TEntity, TId> crudService;

        public BaseController(ICrudService<TEntity, TId> crudService)
        {
            this.crudService = crudService;
        }
        [HttpPost]
        public async Task<TEntity> Post(TEntity entity)
        {
            return await this.crudService.InsertAsync(entity);
        }

        [HttpPut]
        public async Task<TEntity> Put(TEntity entity)
        {
            return await this.crudService.UpdateAsync(entity);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<bool> Delete(TId id)
        {
            return await this.crudService.DeleteByIdAsync(id);
        }

        [HttpGet]
        public async Task<IEnumerable<TEntity>> Get()
        {
            return await this.crudService.FindAllAsync();
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<TEntity> Get(TId id)
        {
            return await this.crudService.FindByIdAsync(id);
        }

    }
}
