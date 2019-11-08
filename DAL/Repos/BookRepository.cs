using DAL.DB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class BookRepository<T> : IBookRepository<T> where T : class
    {

        private BookContext context = null;
        private IDbSet<T> table => context.Set<T>();

        public BookRepository(BookContext context)
        {
            this.context = context;
        }
        public void Create(T item)
        {
            table.Add(item);
        }

        public void Delete(int? id)
        {
            T temp = table.Find(id);
            table.Remove(temp);
        }

        public void Delete(T item)
        {
            table.Remove(item);
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public T GetItemByExpression(Expression<Func<T, bool>> filter)
        {
            return table.FirstOrDefault(filter);
        }
            
        public T GetItemById(int? Id)
        {
            return table.Find(Id);
        }

        public IEnumerable<T> GetItemList()
        {
            return table.ToList();
        }

     

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T item)
        {
            table.Attach(item);
            context.Entry(item).State = EntityState.Modified;
        }
    }
}
