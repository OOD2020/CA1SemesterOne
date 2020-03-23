/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date : 5/ 11/ 2019
 * Description : CA solution
 * 
 * ############################# */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1
{
    class Program
    {
        static void Main(string[] args)
        {
            //list initialiser
            List<Book> ReadingList = new List<Book>();

            //creating 5 objects
            Book book1 = new Book("James Joyce", "Ulysses ", 2 / 21 / 922, "Literature");
            Book book2 = new Book(" B Kernighan and D Ritchie ", "The C Programming Language ", 28 / 02 / 1978, "Computing");
            Book book3 = new Book("Walter Isaacson ", " Steve Jobs ", 24 / 10 / 2011, "Biography");
            Book book4 = new Book(" JRR Tolkien", "The Hobbit  ", 21 / 09 / 1937, "Fiction");
            Book book5 = new Book("James Joyce", "Portrait of the Artist ", 29 / 12 / 1916, "Literature");

            //adding the objects to the list
            ReadingList.Add(book1);
            ReadingList.Add(book2);
            ReadingList.Add(book3);
            ReadingList.Add(book4);
            ReadingList.Add(book5);
            Display(ReadingList);

        }//end of main method 

        //Displaying the entire list
        static void Display(List<Book> books)
        {
            Console.WriteLine("{0,-15}{1,-7}{2,-7}{3,-7}{4,-7}{5,-7}", "NAME", "AUTHOR", "PUBLISH DATE", "GENRE");

            foreach (Book book in books)
            {
                Console.WriteLine(book.BookList());
            }
        }//end of method
    }
}
