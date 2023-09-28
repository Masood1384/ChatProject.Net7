using Microsoft.EntityFrameworkCore;
using Chat.Core.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.Core.Domain;
using Chat.Data.Context;

namespace Chat.Data.Repository
{
    public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly IApplicationContext _contxet;

        public EFRepository(IApplicationContext context)
        {
            _contxet = context;
        }

        private DbSet<TEntity> entities;

        protected DbSet<TEntity> Entities
        {
            get
            {
                if (entities == null)
                    entities = _contxet.Set<TEntity>();
                else
                {
                    return entities;
                }

                return entities;
            }
        }
        public IQueryable<TEntity> GetAll => Entities;

        public IQueryable<TEntity> GetAllAsNotraking => Entities.AsNoTracking();

        public async Task Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            await _contxet.Set<TEntity>().AddAsync(entity);
            await _contxet.SaveChangesAsync();

        }

        public async Task Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _contxet.Set<TEntity>().Remove(entity);
            await _contxet.SaveChangesAsync();
        }

        public async Task<TEntity> GetbyId(int id)
        {
            var item = await _contxet.Set<TEntity>().FindAsync(id);
            return item;
        }

        public TEntity GetbyIdAznotraking(params object[] ids)
        {
            var item = _contxet.Set<TEntity>().Find(ids);
            if (item != null)
            {
                _contxet.Entry(item).State = EntityState.Detached;
            }
            return item;
        }

        public async Task Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            _contxet.Set<TEntity>().Update(entity);
            await _contxet.SaveChangesAsync();
        }
    }
}
