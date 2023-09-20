using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using coPower_Logistics;

namespace EcoPower_Logistics.Repository
{

    public class GenericRepository<T>  : IGenericRepository<T> where T : class
    {
        protected readonly  SuperStoreContext _context;
        public GenericRepository(SuperStoreContext  context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }
        public T GetById(int id)
        {
            if (_context == null || _context.Set<T>() == null)
            {
               
                throw new NullReferenceException("The context or DbSet is null.");
            }
            return _context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }
        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }


    }
}