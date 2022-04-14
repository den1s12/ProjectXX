using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 1, 2, 3, 4 };
            for (int i=0; i<numbers.Length;i++)
            {
                numbers[i] *= 2;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
