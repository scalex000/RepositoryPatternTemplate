/*
 * Repository its a colletion of object so, you don't return IEnumerable,
 * DTO/Model, and do not perform updates.
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Sofymatic.Repository.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity:  class
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> precicate);
        void Add(TEntity entity);
        void AddRange(TEntity entities);
        IEnumerable<TEntity> All(Expression<Func<TEntity, bool>> predicate);
        void Remove(TEntity Entity);
        void RemoveRange(TEntity entities);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predictate);
    }
}
