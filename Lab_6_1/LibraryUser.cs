using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
   
    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser

    interface ILibraryUser
    {
        void AddBook(string nameBook);

        void RemoveBook(string bookName);

        string BookInfo(int index);

        int BooksCount();

    }

    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser: ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        public string FirstName { get;}
        public string LastName { get;}
        public int Id { get;}
        public string Phone { get; set; }
        public int BookLimit { get;}

        // 4) declare field (bookList) as a string array
        string[] bookList;

        // 5) declare indexer BookList for array bookList
        int BookList=0;

        // 6) declare constructors: default and parameter
        public LibraryUser()
        {
            FirstName = "SomeFirstName";
            LastName = "SomeLastName";
            Id = 0;
            Phone = "+380971272314";
            BookLimit = 5;
            bookList = new string[BookLimit];
        }

        public LibraryUser(string FirstName, string LastName, int Id, string Phone, int BookLimit)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Id = Id;
            this.BookLimit = BookLimit;
            bookList = new string[this.BookLimit];
        }

        // 7) declare methods: 

        //AddBook() – add new book to array bookList
        public void AddBook(string nameBook)
        {
            BookList++;
            bookList[BookList] = nameBook;
        }

        //RemoveBook() – remove book from array bookList
        public void RemoveBook(string bookName)
        {
            for(int i=0;i<BookList;i++)
            {
                if (bookName== bookList[i])
                {
                    bookList[i] = bookList[BookList];
                    BookList--;
                }
            }
        }

        //BookInfo() – returns book info by index
        public string BookInfo(int index)
        {
            return bookList[index];
        }

        //BooksCout() – returns current count of books
        public int BooksCount()
        {
            return BookList;
        }
    }


}
