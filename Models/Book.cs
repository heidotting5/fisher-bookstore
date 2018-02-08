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
    public class Book
    {
        public int BookId { get; set; }

        public String Title { get; set; }

        public Author Author { get; set; }

        public void SellBook()
        {
            // code to sell book goes here
        }
    }
}