using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Repository
{
    public interface IProductRepository<T> where T : class

    {
        IEnumerable<T> GetAll(); //get all products
        T GetByID(object ID);    // get a particlar prodct
        void Insert(T obj);
        void Update(T obj);
        void Delete(T obj);
        void Save();
    }
}
