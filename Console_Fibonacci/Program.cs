using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Fibonacci
{
    class Program
    {

        public static double Fibonacci(int n)
        {
            double a = 0;
            double b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                double temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }


        static void Main(string[] args)
        {
            int n = 15;
            if (args.Length != 0)
                n = Convert.ToInt32(args[0]);

            Console.Out.WriteLine("FIBONACCI default 15, you may add argument after filename. (c)2017 Devosa Iván bulid date: 2017.06.14. & 00000 2020.06.27.");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + ": " + Fibonacci(i));
            }
            Console.ReadKey();
        }
    }
}
