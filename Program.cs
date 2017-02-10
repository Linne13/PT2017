using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int n = int.Parse(s);
            int sum = 0;
            int a;

            while (n != 0)
            {
                a = n % 10;
                n = n / 10;
                sum = a + sum;
                Console.WriteLine(n);
            }
          
            Console.Write(sum);
            Console.ReadKey();

        }
    }
}
