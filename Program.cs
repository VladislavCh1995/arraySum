using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 8, 6, 9 };
            int maxElement = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    Console.WriteLine(maxElement);
                }
            }
        }
    }
}
