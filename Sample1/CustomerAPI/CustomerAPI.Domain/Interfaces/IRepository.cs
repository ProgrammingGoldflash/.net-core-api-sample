using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CustomerAPI.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        #region Public Methods

        /// <summary>
        /// Adds the given entity to storage
        /// </summary>
        /// <param name="entitiy">Entity that should be saved</param>
        /// <returns></returns>
        T Add(T entitiy);

        /// <summary>
        /// Adds the given entities to storage
        /// </summary>
        /// <param name="entities">Entities that should be saved</param>
        /// <returns></returns>
        IEnumerable<T> AddRange(IEnumerable<T> entities);

        /// <summary>
        /// Try to get entity by expression
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        T Find(Expression<Func<T, bool>> expression);

        /// <summary>
        /// Try to get an entity by the given id
        /// </summary>
        /// <param name="id">The primary key of the requested entity</param>
        /// <returns></returns>
        T GetById(int id);

        /// <summary>
        /// Removes the given entity from storage
        /// </summary>
        /// <param name="entity">Entity that should be removed</param>
        void Remove(T entity);

        /// <summary>
        /// Removes the given entities from storage
        /// </summary>
        /// <param name="entities">Entities that should be removed</param>
        void RemoveRange(IEnumerable<T> entities);

        /// <summary>
        /// Updates the given entity in storage
        /// </summary>
        /// <param name="entity">Entity that should be updated</param>
        /// <returns></returns>
        T Update(T entity);

        #endregion Public Methods
    }
}