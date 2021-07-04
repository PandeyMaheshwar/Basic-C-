using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Class3
    {
		static void Main()
		{
			Console.WriteLine("Enter the no");
			int num = int.Parse(Console.ReadLine());
			Console.WriteLine("enter the no");
			int j = int.Parse(Console.ReadLine());
			for (int k = num; k <= j; k++)
			{
				int count = 0;

				for (int n = 2; n < k; n++)
				{
					if (k % n == 0)
					{
						count++;
						break;
					}


				}
				if (count == 0)
				{
					//Console.WriteLine(k);
					if (k % 2 == 0)
					{
						Console.WriteLine(k + "is even");

					}
					else
					{
						Console.WriteLine(k + "is odd");
					}

				}
			}

		}
	}
}
