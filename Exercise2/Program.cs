using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Program
    {
        int[] prim = new int[71];




        //Number of elements in array
        int n, i, pr, val, flag;
        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n====================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n====================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                prim[i] = Int32.Parse(s1);

            }
        }
        public void InsertionSort()
        {
            for (i = 1; i < n; i++)
            {
                val = prim[i];
                flag = 0;
                for (pr = i - 1; pr >= 0 && flag != 1;)
                {
                    if (val < prim[pr])
                    {
                        prim[pr + 1] = prim[pr];
                        pr--;
                        prim[pr + 1] = val;
                    }
                    else flag = 1;
                }









            }
        }
    }
}

