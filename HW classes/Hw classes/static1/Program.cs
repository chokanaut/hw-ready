using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static1
{
    class Book
    {
        public class Notes
        {
            private string[] texts = new string[20];

            public void AddNote(int i, string text)
            {
                texts[i] = text;
            }

        }

        public Notes notes = new Notes();

        public Book()
        {
            WriteNote(0, "first note");
        }

        public void WriteNote(int i, string text)
        {
            notes.AddNote(i, text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.WriteNote(1, "second note");
        }
    }
}
