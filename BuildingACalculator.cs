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
			int num = Convert.ToInt32("45");//inside () there has to be a number
			Console.WriteLine("43" + "56");
			Console.WriteLine(num + 6);
			Console.Write("Enter a number 1: ");
			double num1 = Convert.ToDouble(Console.ReadLine());//string is the input so convert it to integer and we used double so that we can add them too..
			Console.Write("Enter a number 2: ");
			double num2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine(num1 + num2);
		}
	}
}
