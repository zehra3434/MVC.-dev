using Microsoft.EntityFrameworkCore;
using MVC.SQLite3.EF.DAL.Abstract;
using SQLitePCL;
using System.Collections.Generic;
using System.Linq;

namespace MVC.SQLite3.EF.DAL.Concrete.EF
{
    public class BaseRepository<T, TContext> : IEntityRepository<T>
        where T:class,new()
        where TContext:DbContext,new()
    {
        public void Add(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<T> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public void Update(T entity)
        {
            using (var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
