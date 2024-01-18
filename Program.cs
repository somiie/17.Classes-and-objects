using System;

namespace _17.Classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book(); //create a new book object, at this point Book is now a data type in C#

            //creation of first book, you can now create thousands of different book eg for a library app!
            book1.title = "Harry Potter";
            book1.author = "Jk Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "lord of the rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);
            //freeze
            Console.ReadLine();
        }
    }
}
