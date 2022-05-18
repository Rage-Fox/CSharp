using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();//book abject or physical book inside this program
            book1.title = "Harry Potter";
            book1.author = "J.K.Rowling";
            book1.pages = 400;
            Console.WriteLine(book1.title);
            Book book2 = new Book();
            book2.title = "Lord Of The Rings";
            book2.author = "Tolkein";
            book2.pages = 700;
            Console.WriteLine(book2.author);
        }
    }
}
