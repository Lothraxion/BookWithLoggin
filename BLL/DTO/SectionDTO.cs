﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class SectionDTO
    {
        public string Name { get; set; }
        public List<BookDTO> Books { get; set; }
    }
}
