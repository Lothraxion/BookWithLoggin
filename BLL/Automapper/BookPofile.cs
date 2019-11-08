using AutoMapper;
using BLL.DTO;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Automapper
{
   public class BookPofile:Profile
    {
        public BookPofile()
        {
            CreateMap<Tag, string>().ConvertUsing(x => x.Name);
            CreateMap<Book, BookDTO>();



            CreateMap<BookDTO, Book>().ForMember(x => x.Tags, y => y.Ignore());
        }
    }
}
