using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
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

           XmlSerializer xsSubmit = new XmlSerializer(typeof(List<Book>));

           using (var sww = new StringWriter())
           {
               using (XmlWriter writer = XmlWriter.Create(sww))
               {
                   xsSubmit.Serialize(writer, books);
                   string xml = sww.ToString(); // Your XML

             //      File.WriteAllText();
               }
           }

            //Publiser p = new Publiser();

            //PubliserRepository pRepo = new PubliserRepository();
            //pRepo.InsertPublisher(p);

            foreach (var book in books)
           {
               Console.WriteLine($"{book.Title} - {book.Price}");
           }
        }
    }
}
