using Airport.Domain.Repositiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.DataAccess
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        protected readonly IDictionary<Guid, TEntity> _entities;

        public BaseRepository()
        {
            _entities = new Dictionary<Guid, TEntity>();

            AddSeeds();
        }

        protected abstract void AddSeeds();
       

        public Task Create(TEntity entity)
        {
            _entities.Add(entity.Id, entity);

            return Task.CompletedTask;
        }

        public Task Delete(TEntity entity)
        {
            _entities.Remove(entity.Id);

            return Task.CompletedTask;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _entities.Values.AsQueryable();
        }

        public Task<TEntity> GetById(Guid id)
        {
            var u= Task.FromResult(_entities.Values.Where(x=>x.Id==id).FirstOrDefault());
            return u;
        }

        public Task Update(TEntity entity)
        {
            _entities[entity.Id] = entity;

            return Task.CompletedTask;
        }
    }
}
