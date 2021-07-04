using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class2
    {
        static void Main(string[] args)
        {

            int count = 0;
            repeat:
            Console.WriteLine("Enter the no");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine("Want to continue press y/n");
            char d = char.Parse(Console.ReadLine());
            char c = 'y';
            char e = 'n';

            if (d == c)
            {
                goto repeat;
            }

            else if (d == e)
            {
                Console.WriteLine("thanks");
            }
           
            
        }
    }
}
