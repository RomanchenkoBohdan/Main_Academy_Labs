using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Work_2._1
{
    interface ILibraryUser
    {
        public void AddBook(string name);
        public void RemoveBook(string name);
        public string BookInfo(int i);
        public int BooksCount();
    }
}
