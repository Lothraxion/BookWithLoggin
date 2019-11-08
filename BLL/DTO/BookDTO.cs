using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
   public class BookDTO
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int ReleaseYear { get; set; }
        public int Amount { get; set; }
        
        public string SectionName { get; set; }
        public List<string> Tags { get; set; }
    }
}
