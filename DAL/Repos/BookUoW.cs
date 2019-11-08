using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DB;
using DAL.Entities;

namespace DAL.Repos
{
   public class BookUoW : IBookUoW
    {
        private readonly BookContext _bookContext;
        public IBookRepository<Tag> TagRepository =>
          new BookRepository<Tag>(_bookContext);

        public IBookRepository<Book> BookRepository =>
             new BookRepository<Book>(_bookContext);

        public IBookRepository<Section> SectionRepository =>
             new BookRepository<Section>(_bookContext);

        public BookUoW(string ConntectionString)
        {
            _bookContext = new BookContext(ConntectionString);
        }
        public void CommtiChanges()
        {
            _bookContext.SaveChanges();
        }

        public void Dispose()
        {
            _bookContext.Dispose();
        }

        public void RejectChanges()
        {
            foreach (var entry in _bookContext.ChangeTracker.Entries()
              .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
