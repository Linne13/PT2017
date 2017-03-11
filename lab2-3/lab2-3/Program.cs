using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2_3
{
    class Program
    {
        private static int i;

        static string prime(string a)
        {
            string line = File.ReadAllText("numbers.txt");
            string[] p = line.Split(' ');
            int primenum = int.Parse(p[i]);
            int m = 0;
            for (int i = 0; i < p.Length; i++)
            {
                int b = int.Parse(p[i]);
                if (b > 0)
                {
                    m = 0;

                    for (int h = 2; h < b; h++)
                    {
                        if (b % h == 0)
                        {
                            m = 1;
                        }
                    }
                }
                if (m == 0 && b <= primenum)
                {
                    primenum = b;
                }
                if (b == 1)
                {
                    primenum = 1;
                }
                if (b == 2 && primenum >= 2)
                {
                    primenum = 2;
                }

            }
            return primenum.ToString();
        }


        static void Main(string[] args)
        {

            string line = File.ReadAllText("numbers.txt");
            string[] p = line.Split(' ');
            int max = int.Parse(p[0]);
            int min = int.Parse(p[0]);
            if (p.Length > 1)
            {
                for (int i = 0; i < p.Length - 1; i++)
                {
                    int b = int.Parse(p[i]);
                    int c = int.Parse(p[i + 1]);
                    if (b >= c && b >= max)
                    {
                        max = b;
                    }
                    else
                    {
                        if (b <= c && c >= max)
                        {
                            max = c;
                        }

                    }
                }
                for (int i = 0; i < p.Length - 1; i++)
                {
                    int b = int.Parse(p[i]);
                    int c = int.Parse(p[i + 1]);
                    if (b <= c && b <= min)
                    {
                        min = b;
                    }
                    else
                    {
                        if (c <= b && c <= min)
                        {
                            min = c;
                        }

                    }
                }

                string s = "numbers.txt";
                string prostoe = prime(s);

                Console.WriteLine("max = " + max);
                Console.WriteLine("min = " + min);
                Console.WriteLine("prostoe = " + prostoe);
                File.WriteAllText("numbers.txt", prostoe);
            }

        }
    }
}
