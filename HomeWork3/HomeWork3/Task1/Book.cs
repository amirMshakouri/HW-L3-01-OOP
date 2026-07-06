using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task1
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public string ISBN { get; set; }

        public bool IsAvailable { get; set;  }

        public Book(string title, string author, string iSBN, bool isAvailable)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            IsAvailable = isAvailable;
        }
    }
}
