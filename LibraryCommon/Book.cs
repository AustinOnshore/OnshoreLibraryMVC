﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCommon
{
    public class Book
    {
        public int BookID { get; set; } // primary key
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsPaperback { get; set; }
        public DateTime PublishDate { get; set; }
        public int AuthorID_FK { get; set; }
        public int GenreID_FK { get; set; }
        public int PublisherID_FK { get; set; }
    }
}
