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
			Console.WriteLine("Rage\nFox");
			Console.WriteLine("Rage\"Fox");//printing " in middle of sentence needs \
			string phrase = "Rage Fox" + " is angry";
			Console.WriteLine(phrase);
			Console.WriteLine(phrase.Length);//length of string
			Console.WriteLine(phrase.ToUpper());// . is called method which bascically denotes inbuilt codes or functions
			Console.WriteLine(phrase.ToLower());
			Console.WriteLine(phrase.Contains("Rage"));//true or false
			Console.WriteLine(phrase.IndexOf("Academy"));//at what position the string starts in the phrase
			Console.WriteLine(phrase.IndexOf('Z'));//if not there it shows -1 denoting character is not there
			Console.WriteLine(phrase.Substring(5, 3));//starting index and grabbing only 3 characters
		}
	}
}
