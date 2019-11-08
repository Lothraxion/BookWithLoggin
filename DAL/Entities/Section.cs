using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Section
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }


        public Section()
        {
            Books = new List<Book>();
        }

    }
}
