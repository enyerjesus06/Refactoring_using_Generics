using Microsoft.EntityFrameworkCore;
using Refactoring_using_Generics.Base;
using Refactoring_using_Generics.Entities;
using Refactoring_using_Generics.Interfaces;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Refactoring_using_Generics.Base
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;

        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Agregar(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Actualizar(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Remover(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public List<T> TraerTodos()
        {
            return _dbSet.ToList();
        }

        public T ObtenerPorId(int id)
        {
            return _dbSet.Find(id);
        }
    }
}
