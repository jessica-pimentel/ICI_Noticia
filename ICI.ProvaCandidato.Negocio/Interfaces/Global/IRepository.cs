using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Negocio.Interfaces.Global
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task Add(TEntity entity);

        Task Add(IEnumerable<TEntity> entity);

        Task Update(TEntity entity);

        Task Delete(int id);

        Task<int> SaveChanges();
    }
}
