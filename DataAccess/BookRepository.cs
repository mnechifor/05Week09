﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Connection;
using Entities;

namespace DataAccess
{
    public class BookRepository
    {
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            try
            {
                var query = "select * from [Book]";

                var connection = ConnectionManager.GetConnection();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    var currentRow = dataReader;

                    Book book = new Book();

                    book.BookId = (int)currentRow["BookId"];
                    book.Title = currentRow["Title"].ToString();
                    book.PublisherId = currentRow["PublisherId"] as int? ?? 0;
                    book.Year = currentRow["Year"] as int? ?? default(int);
                    book.Price = currentRow["Price"] as decimal? ?? default(decimal);

                    books.Add(book);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return books;
        }
    }
}
