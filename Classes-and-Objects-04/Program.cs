using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

          
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Entering details for Book{i+ 1}:");
                Book mybook = new Book();
                mybook.InputBook();
                books.Add(mybook);
            }

            
            Console.WriteLine("List of Books:");
            foreach (var book in books)
            {
                book.PrintBooks();
            }

            
            Console.Write("Enter the title of the book to search: ");
            string searchTitle = Console.ReadLine();
            SearchBook(books, searchTitle);
        }

        
        static void SearchBook(List<Book> books, string title)
        {
            foreach (var book in books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(" Book found:");
                    book.PrintBooks();
                    return;
                }
            }
            Console.WriteLine("Book  is not found.");
        }
    }
}
   
