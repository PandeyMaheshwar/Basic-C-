using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int rev = 0;
            Console.WriteLine("Enter the no");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {

                int rem = n % 10;
                 rev = rev * 10 + rem;
                n /= 10;


             }
            Console.Write("Reversed order" + rev);
        }
    }
}
