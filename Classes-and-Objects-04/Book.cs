using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_04
{
    internal class Book
    {
        public string ISBN;
        public string Title;
        public string Price;
        public string MajorArea;
        public string SubArea;
        public int NoOfPages;

        public void InputBook()
        {
            Console.WriteLine("Enter ISBN : ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter title: ");
            Title = Console.ReadLine();
            Console.WriteLine(" Enter Price : ");
            Price = Console.ReadLine();
            Console.WriteLine(" Enter Major Area : ");
            MajorArea = Console.ReadLine();
            Console.WriteLine(" Enter Sub Area : ");
            SubArea = Console.ReadLine();
            Console.WriteLine(" Enter No of Pages : ");
            NoOfPages = int.Parse(Console.ReadLine());


        }
        public void PrintBooks()
        {
            Console.WriteLine($" ISBN : {ISBN}, Title :{Title}, Price : {Price}, MajorArea : {MajorArea}, SubArea : {SubArea} , NoOfPages : {NoOfPages}");
        }
    }
}
