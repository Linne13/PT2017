using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
             int max = File.ReadAllLines("numbers.txt").Select(int.Parse).Max();
             int min = File.ReadAllLines("numbers.txt").Select(int.Parse).Min();

             Console.WriteLine("Maximum:" + " " + max);
             Console.WriteLine("Minimum:" + " " + min);
             Console.ReadKey(); 
          
        }
    }
}
