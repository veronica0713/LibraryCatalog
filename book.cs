using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace LibraryCatalogue
{

    [Serializable()]
    class Book : ISerializable
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Language { get; set; }

        public Book()
        {

        }
        
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Author", Author);
            info.AddValue("Year", Year);
            info.AddValue("Genre", Genre);
            info.AddValue("Language", Language);
        }

        public Book(SerializationInfo info, StreamingContext context)
        {
            Title = (string) info.GetValue("Title", typeof(string));
            Author = (string)info.GetValue("Author", typeof(string));
            Year = (int)info.GetValue("Year", typeof(int));
            Genre = (string)info.GetValue("Genre", typeof(string));
            Language = (string)info.GetValue("Language", typeof(string));
        }
    }
}
