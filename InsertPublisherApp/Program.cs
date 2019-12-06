using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Entities;

namespace InsertPublisherApp
{
    class Program
    {
        static void Main(string[] args)
        {
           BookRepository bookRepository = new BookRepository();

           List<Book> books = bookRepository.GetAllBooks();

        }
    }
}
