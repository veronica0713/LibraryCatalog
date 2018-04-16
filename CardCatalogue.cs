using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace LibraryCatalogue
{
    public class CardCatalogue
    {
        private string _fileName;

        public CardCatalogue(string fileName)
        {
            _fileName = fileName;
        }

        List<Book> books = new List<Book>();

        public void AddBook()
        {
            Console.WriteLine("Please enter a title");
            string Title = Console.ReadLine();
            Book myBook = new Book();
            myBook.Title = Title;
            
            Console.WriteLine("Please enter an author");
            string Author = Console.ReadLine();            
            myBook.Author = Author;
            
            Console.WriteLine("Please enter a year");
            int Year = Convert.ToInt32(Console.ReadLine());
            myBook.Year = Year;
            
            Console.WriteLine("Please enter a genre");
            string Genre = Console.ReadLine();
            myBook.Genre = Genre;
           
            Console.WriteLine("Please enter a language");
            string Language = Console.ReadLine();
            myBook.Language = Language;
            books.Add(myBook);
        }
        
        public void ListBooks()
        {
            Console.WriteLine("List of books:");
            foreach (Book b in books )
            {
                Console.WriteLine("{0} {1} {2} {3} {4}",b.Title, b.Author, b.Year, b.Genre, b.Language);
            }
        }

        public void Save()
        {
            Stream stream = File.Open(_fileName, FileMode.Create);

            //Binary:
           // BinaryFormatter bf = new BinaryFormatter();
           // bf.Serialize(stream, books);
          // stream.Close();

            //XML:
            
            XmlSerializer serializer  = new XmlSerializer(typeof(List<Book>));
            serializer.Serialize(stream, books);
            stream.Close();
        }


    }
}
