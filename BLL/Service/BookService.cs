using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using DAL.Repos;

namespace BLL.Service
{
    public class BookService : IBookService
    {
        public IBookUoW unitOfWork { get; private set; }
        public BookService(IBookUoW unit)
        {
            this.unitOfWork = unit;
        }
        public void Add(BookDTO book)
        {
 
            Book tempBook = Mapper.Map<BookDTO, Book>(book);
            foreach (string tag in book.Tags)
            {
                var temptag = unitOfWork.TagRepository.GetItemByExpression(x => x.Name.Equals(tag));

                if (temptag==null)
                {
                    temptag = new Tag { Name = tag };

                    
                }
                tempBook.Tags.Add(temptag);
            }
            var tempSection = unitOfWork.SectionRepository.GetItemByExpression(x => x.Name.Equals(book.SectionName));
            if (tempSection == null)
            {
                tempSection = new Section { Name = book.SectionName };
            }
            tempBook.Section = tempSection;
            unitOfWork.BookRepository.Create(tempBook);
            unitOfWork.CommtiChanges();
        }

        public void Delete(int? id)
        {
            var checkBook = unitOfWork.BookRepository.GetItemById(id);
            if (checkBook != null)
            {
                unitOfWork.BookRepository.Delete(id);
                unitOfWork.CommtiChanges();
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public BookDTO GetBook(int? id)
        {
            var checkBook = unitOfWork.BookRepository.GetItemById(id);
                return Mapper.Map<Book, BookDTO>(checkBook);
        }

        public IEnumerable<BookDTO> GetBooks()
        {
            IEnumerable<Book> books = unitOfWork.BookRepository.GetItemList();
            return Mapper.Map<IEnumerable<Book>, List<BookDTO>>(books);
        }

        public void Update(int? id, BookDTO product)
        {
            var tempBook = unitOfWork.BookRepository.GetItemById(id);
            var tempSection = unitOfWork.SectionRepository.GetItemByExpression(n => n.Name.Equals(product.SectionName));
            List<Tag> temptags = new List<Tag>();
            foreach (var tag in product.Tags)
            {
                temptags.Add(unitOfWork.TagRepository.GetItemByExpression(n => n.Name.Equals(tag)));
            }
            tempBook.Name = product.Name;
            tempBook.ReleaseYear = product.ReleaseYear;
            tempBook.Section = tempSection;
            tempBook.Tags = temptags;
            tempBook.Author = product.Author;
            tempBook.Amount = product.Amount;
            unitOfWork.BookRepository.Update(tempBook);
            unitOfWork.CommtiChanges();
        }
    }
}
