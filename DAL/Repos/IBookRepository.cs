using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public interface IBookRepository<T> : IDisposable
       where T : class
    {
        IEnumerable<T> GetItemList();
        T GetItemById(int? Id);
        void Create(T item);
        void Delete(int? id);
        void Update(T item);
        void Delete(T item);
        void Save();
      
        T GetItemByExpression(Expression<Func<T, bool>> filter);

    }
}
