/*
 * Created by SharpDevelop.
 * User: LEIGH
 * Date: 12/5/2021
 * Time: 8:05 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ITEC102Week9_Jamolin_PerformanceTask2
{
	class Program
	{
		public static void Main(string[] args)
		{
			try
			{
				int num = 0, num1 = 1;
				Console.Write("Enter how many numbers: ");
				num = Convert.ToInt32(Console.ReadLine());
			
				int[] no = new int[num];
				Console.WriteLine("\nNo. \t\tSOF\t\tRemarks");
			
				for (int i = 0; i < num; i++)
				{
					Console.Write("{0}\t\t",num1);
					Console.Write("");
					no[i] = Convert.ToInt32(Console.ReadLine());
					
					num1++;
				}
			
				Console.Clear();
				Console.Write("Enter how many numbers: {0}",num);
				Console.WriteLine();
			
				int num2 = 1;
				Console.WriteLine("\nNo. \t\tSOF\t\tRemarks");
				
				for (int i = 0; i < num; i++)
				{
					if (no[i] > num2)
					{
						Console.WriteLine("{0}\t\t{1}\t\tEfficient",num2,no[i]);
					}
					if (no[i] < num2)
					{
						Console.WriteLine("{0}\t\t{1}\t\tDeficient",num2,no[i]);
					}
					if (no[i] == num2)
					{
						Console.WriteLine("{0}\t\t{1}\t\tPerferct",num2,no[i]);
					}
					num2++;
				}
			}
			catch (Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}