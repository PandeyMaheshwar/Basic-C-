using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no");
            int j = int.Parse(Console.ReadLine());
            for (int i = j; i >= 1; i--)
            
            {
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
           
        }
    }
}
