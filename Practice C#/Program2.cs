using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the employee");
            String name = Console.ReadLine();
            Console.WriteLine("Enter the Salary of the Employee");
            String sal = Console.ReadLine();
            Console.WriteLine("Enter the Empno of the employee");
            String no = Console.ReadLine();

            Console.WriteLine("Name is :" + name + " , Emp no : " + no + " and salary is " + sal);

        }
    }
}
