using Chat.Core.Commons;
using Chat.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        Task Delete(TEntity entity);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task<TEntity> GetbyId(int id);
        TEntity GetbyIdAznotraking(params object[] ids);
        IQueryable<TEntity> GetAll { get; }
        IQueryable<TEntity> GetAllAsNotraking { get; }
        
    }
}
