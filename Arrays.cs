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
			int [] luckyNumbers = { 1, 2, 3, 4, 5};//creating an array
			luckyNumbers[0] = 0;
			string[] friends = new string[5];
			friends[0] = "Jim";
			friends[1] = "Kelly";
                        Console.WriteLine(luckyNumbers[0]);
			Console.WriteLine("[{0}]", string.Join(", ", friends));
			foreach (var item in luckyNumbers)
			{
				Console.Write(item.ToString());
				Console.Write(' ');
			}
		}
	}
}
