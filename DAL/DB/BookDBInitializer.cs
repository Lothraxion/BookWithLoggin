using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
    class BookDBInitializer:DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            Section section = new Section { Name = "Section 1" };
            Tag tag1 = new Tag { Name = "tag1" };
            Tag tag3 = new Tag { Name = "tag2" };
            Tag tag2 = new Tag { Name = "tag3" };
            List<Tag> tags = new List<Tag>();
            tags.Add(tag1);
            tags.Add(tag2);
            tags.Add(tag3);
            Book book1 = new Book { Name = "Book1", ReleaseYear = 2001, Author = "Author1", Amount = 5, Section = section, Tags = tags };
            Book book2 = new Book { Name = "Book2", ReleaseYear = 2031, Author = "Author3", Amount = 45, Section = section, Tags = tags };
            Book book3 = new Book { Name = "Book3", ReleaseYear = 20201, Author = "Author5", Amount = 3, Section = section, Tags = tags };
            Book book4 = new Book { Name = "Book4", ReleaseYear = 201, Author = "Author2", Amount = 235, Section = section, Tags = tags };
            context.Books.Add(book1);
            context.Books.Add(book2);
            context.Books.Add(book3);
            context.Books.Add(book4);
            base.Seed(context);
        }
    }
}
