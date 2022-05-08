using System;
using System.Collections.Generic;
using System.Text;
using _07._05._22_Homework.Models;

namespace _07._05._22_Homework.Interface
{
    interface ILibraryManager 
    {
        static List<Book> books;
        static ILibraryManager() 
        {
            books = new List<Book>();
        }


    }
}
