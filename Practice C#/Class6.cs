using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Consumed unit");
            double unit = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the ype of industry \n 1. Agriculture \n 2. Farm \n 3. Industry");
            int type = int.Parse(Console.ReadLine());
           
            switch(type)
            {
                case 1:
                    if(unit > 120)
                    {
                     
                        Console.WriteLine("Total bill" + (unit * 15));
                        break;
                        
                    }

                    else
                    {
                        
                        Console.WriteLine("your bill" + (unit * 10));
                        break;
                     
                    }

                case 2:
                    if (unit > 120)
                    {

                        Console.WriteLine("Total bill" + (unit * 10));
                        break;

                    }

                    else
                    {

                        Console.WriteLine("your bill" + (unit * 8));
                        break;

                    }

                case 3:
                    if (unit > 120)
                    {

                        Console.WriteLine("Total bill" + (unit * 12));
                        break;

                    }

                    else
                    {

                        Console.WriteLine("your bill" + (unit * 9));
                        break;

                    }
            }
        }
    }
}


