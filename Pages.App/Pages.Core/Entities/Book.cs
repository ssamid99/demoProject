﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pages.Core.Entities
{
    public class Book : BaseModel
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Publisher { get; set; }
        public DateTime PubslishDate { get; set; }
        public int PaperCount { get; set; }
        public string Dimensions { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile? FormFile { get; set; }
        public List<BookAuthor>? BookAuthors { get; set; }
        public virtual List<BookLanguage> BookLanguages { get; set; }
        public virtual List<BookGenre> BookGenres { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
