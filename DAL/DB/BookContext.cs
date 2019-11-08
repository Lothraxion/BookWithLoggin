using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DB
{
  public  class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public BookContext(string ConnectionString) : base(ConnectionString)
        {
           // Database.SetInitializer(new BookDBInitializer());
        }

        
    }
}
