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
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);
            int res = Cube(num);
            Console.WriteLine(res);
            Console.WriteLine(Cube(2));
	}
	static int Cube(int num)//int is return type
        {
            int result = num * num * num;
            return result;
        }
	}
}
