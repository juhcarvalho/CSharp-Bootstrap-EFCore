﻿using Controle_de_Habito.Data;
using System;
using System.Linq.Expressions;

namespace Controle_de_Habito.Repository
{
    public class Repository<T> : IDisposable where T : class
    {
        ContextApp _context;
        //DbSet<T> _dbSet;

        public Repository(ContextApp context)
        {
            _context = context;
            //_dbSet = context.Set<T>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        //public void Edit(T entity)
        //{
        //    _context.Entry(entity).State = EntityState.Modified;
        //}

        //public IQueryable<T> FindAll()
        //{
        //    return _context.Set<T>();
        //}
        //public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        //{
        //    return _dbSet.Where(predicate);
        //}

        //public T FindById(int id) 
        //{
        //    return _dbSet.Find(id);
        //}

        //public void Remove(T entity) 
        //{
        //    _context.Set<T>().Remove(entity);
        //}

        //public void Add(T entity)
        //{
        //    _context.Set<T>().Add(entity);
        //}
    }
}
