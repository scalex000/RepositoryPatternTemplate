using Microsoft.EntityFrameworkCore;
using Sofymatic.Repository.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Sofymatic.Repository.Persistence.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        private readonly DbSet<TEntity> _entities;

        public Repository(DbContext context)
        {
            this.Context = context;
            this._entities = this.Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            this._entities.Add(entity);
        }

        public void AddRange(TEntity entities)
        {
            this._entities.AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return this._entities.Where(predicate);
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this._entities.SingleOrDefault(predicate);
        }

        public TEntity Get(int id)
        {
            return this._entities.Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public void Remove(TEntity entity)
        {
            this._entities.Remove(entity);
        }

        public void RemoveRange(TEntity entities)
        {
            this._entities.RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return this._entities.SingleOrDefault(predicate);
        }
    }
}
