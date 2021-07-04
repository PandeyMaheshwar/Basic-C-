using System;

public class pattern
{

	public static void Main(string[] args)
	{
		// TODO Auto-generated method stub


		Console.WriteLine("enter the no");
		int k = int.Parse(Console.ReadLine());
		Console.WriteLine("enter another no");
		int l = int.Parse(Console.ReadLine());
		for (int i = k; i <= l; i++)
		{
			for (int j = l; j >= k; j--)
			{
				if (i >= j)
				{
					if (i % 2 == 0)
					{
						Console.Write((i)+"  ");
					}
					i++;
				}
				else
				{
					Console.Write(" ");
				}
			}
			Console.WriteLine();
		}
	}
}
