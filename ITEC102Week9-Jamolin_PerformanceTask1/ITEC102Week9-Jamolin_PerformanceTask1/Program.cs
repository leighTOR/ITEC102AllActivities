/*
 * Created by SharpDevelop.
 * User: LEIGH
 * Date: 12/5/2021
 * Time: 7:55 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ITEC102Week9_Jamolin_PerformanceTask1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Number to Words Conversion\nEnter any number from 0 to 9999\n");
			
			try
			{
				for (int i = 0; i < 10000; i++)
				{
					Console.Write("Enter #{0}: ",i+1);
					int num = Convert.ToInt32(Console.ReadLine());
					
					if (num.Equals(0)) Console.Write("zero");
					if (num > 9999)
					{
						Console.WriteLine("Error. Input should only be 0 to 9999.\n");
						break;
					}
						
					conversion(num);
					Console.WriteLine();
				}
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		public static void conversion(int num)
		{
			string[] words = new string[] {"", "one", "two", "three", "four",
				"five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen",
				"fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty",
				"thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
			

			if (num > 999)
			{
				int leftmost = num / 1000;
				Console.Write("{0} thousand ",words[leftmost]);
				num -= leftmost * 1000;
			}
			
			if (num > 99)
			{
				int leftmost = num / 100;
				Console.Write("{0} hundred ",words[leftmost]);
				num -= leftmost * 100;
			}
		
			if(num > 20)
			{
				int leftmost = num / 10;
				Console.Write("{0} ",words[leftmost + 18]);
				num -= leftmost * 10;
			}
			Console.Write(words[num]);
			Console.WriteLine();
			
		}
	}
}