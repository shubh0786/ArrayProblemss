using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[10];
            int i;

            Console.WriteLine("please input 10 numbers");
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("following are the inputs for {0} its : ",i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Elements in array are : ");
            for ( i = 0; i < 10; i++)
            {

                Console.WriteLine("{0} " , arr[i]);

            }

            Console.ReadLine();

        }
    }
}
