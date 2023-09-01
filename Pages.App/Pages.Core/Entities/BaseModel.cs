﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Core.Entities
{
    public class BaseModel
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set;}
    }
}
