using Airport.Domain.Repositiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirPort.DataAccess
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : IEntity
    {
        public Task Create(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Guid id, TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
