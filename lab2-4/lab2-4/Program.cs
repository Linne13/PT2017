using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_4
{
    public class Complex
    {
        public int a;
        public int b;

        public Complex()
        {
            a = 0;
            b = 0;

        }

        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;

        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex c = new Complex(0, 0);

            c.a = c1.a + c2.a;
            c.b = c1.b + c2.b;

            return c;
        }
        public override string ToString()
        {
            return this.a + " " + this.b + "*i";
        }
    }


    static void Main(string[] args)
    {
        List<Complex> list = new List<Complex>();
        while (true)
        {

            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            Complex a = new Complex(w, l);
            list.Add(a);

            foreach (Complex k in list)
            {
                Console.WriteLine(k.ToString());
            }
            Console.WriteLine(a + a);

            int p = int.Parse(Console.ReadLine());
            if (p == 0) { break; }
        }
    }
}
