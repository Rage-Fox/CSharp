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
            int index = 1;
            while(index<=5)
            {
                Console.WriteLine(index);
                index++;
            }
            index = 6;
            do
            {
                Console.WriteLine(index);//prints one time and then checks the condition
                index++;
            } while(index<=5);
        }
    }
}
