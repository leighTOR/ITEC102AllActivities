/*
 * Created by SharpDevelop.
 * User: LEIGH
 * Date: 12/5/2021
 * Time: 7:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ITEC102Week9_Jamolin_EngagingActivity
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Odd or Even\nEnter any integer numbers\n");
			
			try
			{
				int i = 0, num1 = 0, num2 = 0;
				do
				{
					num1 = num2;
					Console.Write("#{0}: ",i+1);
					num2 = Convert.ToInt32(Console.ReadLine());
				
					// odd or even
					if (num2 % 2 == 0) Console.WriteLine("Even number");
					else Console.WriteLine("Odd number");
					Console.WriteLine();
					i++;
				}
				while (num2 != (num1 * 2) || i <= 1);
				Console.WriteLine("The program will now close since the last input number (#{0}), {1}" +
				                  " is twice the previous number (#{2}), {3}. \n",i,num2,i-1,num1);
				}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}