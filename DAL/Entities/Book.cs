using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public int ReleaseYear { get; set; }
        
        public int Amount { get; set; }
        public virtual Section Section { get; set; }


        public Book()
        {
            Tags = new List<Tag>();   
        }
    }
}
