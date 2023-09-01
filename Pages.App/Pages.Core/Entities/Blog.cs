﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Core.Entities
{
    public class Blog:BaseModel
    {
        public string? Image { get; set; }
        public string Title { get; set; } 
        public string Author { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }

    }
}
