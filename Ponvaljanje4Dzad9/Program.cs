using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponvaljanje4Dzad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 22, 77, 88, 101, 2, 7, 9 ,20, 77, 83,124,6, 2, 67, 34 };
            Console.Write("Ne sortiran array: ");
            for (int i = 0; i < array.Length - 1    ; i++)
            {
                Console.Write(array[i] +", ");
            }
                for (int i=0; i < array.Length; i++)
            {
                for(int j=0; j< array.Length-i-1; j++)
                {
                    if (array[j] > array[j+1]) { 
                        int tempInt = array[j];
                        array[j] = array[j+1];
                        array[j+1] = tempInt;
                    }

                }
            }
            Console.Write("\r\n\r\nSortiran array: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.ReadLine();
        }
    }
}
