using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserte un numero: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int i;
            for (i = 1; i <= 10; i++) 
            {
                Console.WriteLine(n + " x " + i+  " = " + (n * i));
            }
            Console.ReadKey();

        }
    }
}
