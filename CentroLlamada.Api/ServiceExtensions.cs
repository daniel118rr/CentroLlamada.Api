using CentroLlamada.Application.ApplicationService;
using CentroLlamada.Application.ApplicationService.Impl;
using CentroLlamada.Domain;
using CentroLlamada.Domain.DomainService.Repositories;
using CentroLlamada.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CentroLlamada.Api
{
    public static class ServiceExtensions
    {
        public static void AddEntity<TEntity, TId>(this IServiceCollection services)
            where TEntity : Entity<TId>, new()
            where TId : IComparable, IComparable<TId>
        {
            var mongoHost = Environment.GetEnvironmentVariable("MongoHost");
            var mongoDb = Environment.GetEnvironmentVariable("Database");
            services.AddScoped<IRepository<TEntity, TId>>(it => new PacienteRepository<TEntity, TId>(mongoHost, mongoDb));
            services.AddTransient<ICrudService<TEntity, TId>, CrudService<TEntity, TId>>();
        }

    }
}
