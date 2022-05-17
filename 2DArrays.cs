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
            int[,] numberGrid = {
                { 1,2 },
                { 3,4 },
                { 5,6 }
            };//[,] indicates 2D array
            //increasing commas increases array dimension
            for(int i = 0; i<numberGrid.GetLength(0); i++)
            {
                for(int j = 0; j < numberGrid.GetLength(1); j++)
                {
                    Console.Write(numberGrid[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
