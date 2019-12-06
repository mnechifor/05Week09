﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public int PublisherId { get; set; }

        public int Year { get; set; }

        public decimal Price { get; set; }
    }
}
