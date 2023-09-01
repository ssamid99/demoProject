using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace Pages.Core.Entities
{
    public class BookLanguage : BaseModel
    {
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int LanguageId { get; set; }
        public virtual Language Language { get; set; }
    }
}
