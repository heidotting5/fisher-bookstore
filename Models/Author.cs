using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Fisher.Bookstore.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        public String Name { get; set; }
    }
}