using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static bool isPrime(int a)
        {
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int n = args.Length;
            for (int i = 0; i < n; i++)
            {
                string s = args[i];
                int p = int.Parse(s);
                if (isPrime(p) == true)
                {
                    Console.WriteLine("PRIME");
                }
            }
      
    }

