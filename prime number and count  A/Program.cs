using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_number_and_count__A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Enter the size array:");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            int store = 0;
            int ctr = 0;
            while (ctr < size)
            {
                Console.Write("Enter the " + (ctr + 1) + " value  of  array : ");
                arr[ctr] = int.Parse(Console.ReadLine());
                ctr++;
            }
            Console.Write("my array :");
            int ptr = 0;
            while (ptr < size)
            {
                Console.Write(" " + arr[ptr]);
                ptr++;
            }
            Console.WriteLine();
            Console.Write("prime number :");
            int v=0;
            int count = 0;
            for (int i = 0; i < size; i++)
            {
                store = arr[i];
                for (int j = 1; j < store; j++)
                {
                    if (store % j == 0)
                    {
                        count++;
                    }
                }
                    if (count == 2)
                    {
                        Console.Write(" " + store);
                    v++;
                    }


                
            }
            Console.WriteLine();
            Console.WriteLine("  total "+v);*/
            int store = 0;
            int v = 0;

            Console.Write("Entre the size of array : ");
            int s = int.Parse(Console.ReadLine());

            int[] arr = new int[s];

            Console.WriteLine("Entre the Element in Array :");
            int b = 0;
            while (b < s)
            {
                Console.Write("Elenemt {0} ", b + " ");
                arr[b] = int.Parse(Console.ReadLine());
                b++;
            }
            Console.WriteLine("Elements in array are :");
            int c = 0;
            while (c < s)
            {
                Console.Write(arr[c] + " ");
                c++;
            }
            Console.WriteLine();
            Console.WriteLine("Prime numbers are");


            for (int i = 0; i < s; i++)
            {
                store = arr[i];
                int count;
                count = 0;


                for (int j = 1; j <= store; j++)
                {
                    if (store % j == 0)
                    {
                        count++;
                    }

                }
                if (count == 2)
                {
                    Console.Write(store + " ");
                    v++;
                }

            }
            Console.WriteLine();
            Console.WriteLine("Total prime numbers are  {0} ", v);



            Console.ReadLine();
        }
      
        }
    }

