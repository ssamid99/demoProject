using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pages.Core.Entities
{
    public class Social : BaseModel
    {
        public string Name{ get; set; }
        public string Image { get; set; }
        public IFormFile? FormFile { get; set; }
        public List<AuthorSocial> AuthorSocials { get; set; }
    }
}
