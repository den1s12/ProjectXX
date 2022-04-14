using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delenie
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] numbers = new int[4] { 2, 4, 8, 6 };
                int y = numbers[0];
                for (int e = 0; e < numbers.Length; e++)
                {
                    numbers[e] /= y;
                }
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
