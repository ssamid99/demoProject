﻿using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Core.Entities
{
    public class BookGenre : BaseModel
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
