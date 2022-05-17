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
			string name = Console.ReadLine();
			int age = Convert.ToInt32(Console.ReadLine());
			SayHi(name,age);
			name = Console.ReadLine();
			age = Convert.ToInt32(Console.ReadLine());
			SayHi(name,age);
		}
		//method is a block of code where we can perform a task(bascically a function)
		//only code inside Main will run in C#
		static void SayHi(string name, int age)
        {
			Console.WriteLine("Hello " + name + " you are " + age);
        }
	}
}
