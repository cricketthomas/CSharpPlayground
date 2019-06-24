using System;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground
{
    class Book //blue print for the object data
    {
        // class attributes:
        public string title;
        public string author;
        public int pages;


        public Book(string aTitle, string aAuthor, int aPages) //pass in arguments to perform some sort of process. 
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            Console.WriteLine($"{title}, {author}, pages: count:{pages} created.");
            //Console.WriteLine("Creating a new book");
            //Methods that get called for our class. THis is a constructor

        }
    }
}
