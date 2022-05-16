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
            string phrase = "Rage Fox";
            char grade = 'A';//character needs to be placed in between ''
            int age = -30;
            double gpa = 9.8;//you can also use float or decimal(decimal makes value very precise)
            bool isMale = true;
            Console.WriteLine(phrase + grade + age + gpa + isMale);
            Console.WriteLine(30);//constants which are not stored in any variable
        }
    }
}
