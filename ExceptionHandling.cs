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
            //exception handling is a case where the program crashes because user input wrong info
            //example: dividing with zero or entering alphabet in place of integer
            try
            {
                Console.WriteLine("Enter num1: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter num2: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)//catches the error happened in the program
            {//we can also write exceptional error msg only for (DivideByZeroException e)
                Console.WriteLine("ERROR");
                Console.WriteLine(e.Message);
            }
            finally//final message
            {
                Console.WriteLine("Thank you");
            }
        }
    }
}
