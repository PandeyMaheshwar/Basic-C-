using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("Enter the no");
            int day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Sun");
                    break;
                case 2:
                    Console.WriteLine("Mon");
                    break;
                case 3:
                    Console.WriteLine("Tue");
                    break;
                deafult: Console.WriteLine("invalid");
                    break;
                    Console.ReadLine();


            
            }


        }
    }
        }
    

