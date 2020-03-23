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
    //enum
    public enum Genre { Fiction, Biography, Computing, Literature }
    class Book
    {
        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Type { get; set; }
        //end of properties




         //Constructor
        public Book(string title, string author, int publishDate, string type)

        {
            Title = title;
            Author = author;
            PublishDate = new DateTime(publishDate);
            Enum.TryParse(type, out Genre genre);


        }
      
        //ToString method
        public override string ToString()
        {
            return string.Format("Title: {0} Author: {1} PublishDate: {2}",
                Title, Author, PublishDate);
        }//end of method
        public string BookList()
        {
            return string.Format($"{Title,-15}{Author,-7}{PublishDate,-7}");
        }
    }
}
