using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication11
{
    class Program
    {
        static string prost(string a)
        {
            string line = File.ReadAllText(a);
            string[] param = line.Split(' ');
            int prostoe = int.Parse(param[]);
            int m = 0;
            for (int i = 0; i < param.Length; i++)
            {
                int b = int.Parse(param[i]);
                if (b > 0)
                {
                    m = 0;
                    for (int h = 2; h < b; h++)
                    {
                        if (b % h == 0) { m = 1; }
                    }
                }
                if ((m == 0) && (b <= prostoe)) { prostoe = b; }
                if (b == 1) { prostoe = 1; }
                if ((b == 2) && (prostoe >= 2)) { prostoe = 2; }
            }
        
                return prostoe.ToString();
        }
    static void Main(string[] args)
        {
            string line = File.ReadAllText("numbers.txt");
            string[] param = line.Split(' ');
            int max = int.Parse(param[0]);
            int min = int.Parse(param[0]);
            if (param.Length > 1)
            {
                for (int i = 0; i < param.Length - 1; i++)
                {
                    int b = int.Parse(param[i]);
                    int c = int.Parse(param[i + 1]);
                    if ((b >= c) && (b >= max)) { max = b; }
                    else
                    {
                        if ((b <= c) && (c >= max)) { max = c; }

                    }
                }
                for (int i = 0; i < param.Length - 1; i++)
                {
                    int b = int.Parse(param[i]);
                    int c = int.Parse(param[i + 1]);
                    if ((b <= c) && (b <= min)) { min = b; }
                    else
                    {
                        if ((c <= b) && (c <= min)) { min = c; }

                    }
                }

                string s = "numbers.txt";
                string prostoe = prost(s);

                /*int prostoe = 1000;
                int m = 0;
                for (int i = 0; i < param.Length; i++)
                {
                    if (int.Parse(param[i]) > 0)
                    {
                        m = 0;
                        for (int h = 2; h < int.Parse(param[i]); h++)
                        {
                            if (int.Parse(param[i]) % h == 0) { m = 1; }
                        }
                    }
                    if ((m == 0) && (int.Parse(param[i]) <= prostoe)) { prostoe = int.Parse(param[i]); }
                    if (int.Parse(param[i]) == 1) { prostoe = 1; }
                    if ((int.Parse(param[i]) == 2) && (prostoe >= 2)) { prostoe = 2; }
                }*/

                Console.WriteLine("max = " + max);
                Console.WriteLine("min = " + min);
                Console.WriteLine("prostoe = " + prostoe);
                System.IO.File.WriteAllText("numbers.txt", prostoe);
            }

        
    }
    }
}
