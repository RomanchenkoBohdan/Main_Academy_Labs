using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Work_2._1
{
    class LibraryUser : ILibraryUser
    {
        public readonly string FirstName;
        public readonly string LastName;
        public readonly int Id;
        public string Phone { get; set; }
        public readonly int BookLimit;
        private List<string> bookList { get; set; } = new List<string>();

        public string this[int i] => bookList[i];

        public LibraryUser()
        {
            FirstName = "Vasya";
            LastName = "Pupkin";
            Phone = "+380968364924";
            Id = 1;
        }

        public LibraryUser(string FirstName, string LastName, string Phone, int Id)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Id = Id;
        }

        public void AddBook(string nameBook)
        {
            bookList.Add(nameBook);
        }
        public void RemoveBook(string nameBook)
        {
            bookList.Remove(nameBook);
        }
        public string BookInfo(int i)
        {
           return bookList[i];
        }
        public int BooksCount()
        {
            return bookList.Count;
        }
    }
}
