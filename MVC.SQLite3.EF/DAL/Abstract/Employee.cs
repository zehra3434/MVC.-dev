using System.Collections.Generic;

namespace MVC.SQLite3.EF.DAL.Abstract
{
    public interface IEntityRepository<T>
        where T: class,new ()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
    }
}
