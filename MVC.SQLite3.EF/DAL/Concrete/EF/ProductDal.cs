using MVC.SQLite3.EF.DAL.Abstract;
using MVC.SQLite3.EF.Entities;

namespace MVC.SQLite3.EF.DAL.Concrete.EF
{
    public class EfProductDal : BaseRepository<Product, NorthwindDbContext>, IProductDal { }
}
