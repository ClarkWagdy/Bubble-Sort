using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.Write("enter size of numpers = ");
            x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int z;
            Console.WriteLine("numpers");

            for (int i = 0; i < x; i++)
            {
                z = Convert.ToInt32(Console.ReadLine());
                arr[i] = z;
            }
            Console.WriteLine("your numpers befor sort : ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(arr[i] + ",");
            }

            int temp;

            for (int j = 0; j < x; j++)
            {
                for (int i = j+1; i < x; i++)
                {
                    if (arr[j] > arr[i])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                    else
                    {
                       continue;
                    }

                }

            }
            Console.WriteLine();
            Console.WriteLine("Sorted array by bubble sort is: ");
            for (int i = 0; i < x; i++)
            {
                Console.Write(arr[i] + ", ");
            }

            Console.ReadKey();
        }
    }
}
    

