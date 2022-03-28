using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected readonly MeuDbContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public async Task Atualizar(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> SaveChanges()
        {
            throw new NotImplementedException();
        }
        public async void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
