using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Class3
    {
        public static void Main(String[] args)
        {
            for (int i = 10; i <= 90; i+=10)
            {
                if (i < 40)
                {
                    Console.WriteLine(i+"");
                }
                else if (i <= 50)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.WriteLine(i);
                    //System.out.print("\t");
                }


            }
        }
    }
}
