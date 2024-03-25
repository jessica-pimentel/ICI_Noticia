using ICI.ProvaCandidato.Dados.Context;
using ICI.ProvaCandidato.Negocio.Interfaces.Global;
using ICI.ProvaCandidato.Negocio.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Dados.Repository.cs
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseModel, new()
    {
        protected readonly NoticiaContext _db;
        protected readonly IDbConnection _dapper;
        protected readonly DbSet<TEntity> _dbSet;
        public Repository(NoticiaContext db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
            _dapper = new SqlConnection(_db.Database.GetDbConnection().ConnectionString);
        }

        public virtual async Task Add(TEntity entity)
        {
            _dbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Add(IEnumerable<TEntity> entity)
        {
            _dbSet.AddRange(entity);
            await SaveChanges();
        }

        public virtual async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await SaveChanges();
        }
        public virtual async Task Delete(int id)
        {
            _dbSet.Remove(new TEntity { });
            await SaveChanges();
        }


        public async Task<int> SaveChanges()
        {
            return await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }
    }
}
