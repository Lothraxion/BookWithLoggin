using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public interface IBookService:IDisposable
    {
        void Add(BookDTO book);
        void Delete(int? id);
        void Update(int? id, BookDTO product);
        BookDTO GetBook(int? id);
        IEnumerable<BookDTO> GetBooks();

    }
}
