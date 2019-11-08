using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public interface IBookUoW:IDisposable
    {
        IBookRepository<Tag> TagRepository { get; }
        IBookRepository<Book> BookRepository { get; }
        IBookRepository<Section> SectionRepository { get; }
        void CommtiChanges();
        void RejectChanges();
    }
}
