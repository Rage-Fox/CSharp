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
			Console.WriteLine("Hello!");
			Console.Write("Enter your name: ");
			string name = Console.ReadLine();//allows user to enter input
			Console.Write("Enter your age: ");
			string age = Console.ReadLine();
			Console.WriteLine("Hello " + name + " you are " + age);
		}
	}
}
