using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_4
{
    class Program
    {
        class Complex
        {
            public int x, y;
            public Complex(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public void Print()
            {
                Console.WriteLine(x + "/" + y);
            }


            public override string ToString()
            {
                return x + "/" + y;
            }


            public Complex Add(Complex c)
            {
                Complex d = new Complex(this.x * c.y + c.x * this.y, this.y * c.y);
                return d;
            }

            public static Complex operator +(Complex c1, Complex c2)
            {
                Complex c = new Complex(c1.x * c2.y + c2.x * c1.y, c1.y * c2.y);
                return c;
            }
        }

        static void Main(string[] args)
        {
            List<Complex> list = new List<Complex>();
            while (true)
            {

                int w = int.Parse(Console.ReadLine());
                int l = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                int y = int.Parse(Console.ReadLine());

                Complex a = new Complex(w, l);
                list.Add(a);
                Complex b = new Complex(x, y);
                list.Add(b);


                Console.WriteLine(a + b);


            }
            /*Complex a = new Complex(1, 2);
            Complex b = new Complex(2, 3);
            Complex c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();*/
        }
    }
}
