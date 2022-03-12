/*
 * Created by SharpDevelop.
 * User: LEIGH
 * Date: 11/7/2021
 * Time: 11:36 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ITEC102Week4_Jamolin_PerformaceTask1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter your information\n");
			
			try
			{
				Console.Write("Name              : ");
				string name = Console.ReadLine();
				
				Console.Write("Student ID Number : ");
				int idNum = Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Age               : ");
				int age = Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Course            : ");
				string course = Console.ReadLine();
				
				Console.Write("College Name      : ");
				string collegeName = Console.ReadLine();
				
				Console.WriteLine("\nHello, " + name + ". Here's the data we have gathered from you:");
				Console.WriteLine("Name              = " + name);
				Console.WriteLine("Student ID Number = " + idNum);
				Console.WriteLine("Age               = " + age + " years old");
				Console.WriteLine("Course            = " + course);
				Console.WriteLine("College Name      = " + collegeName);
				
				Console.WriteLine("\n================================================================\n");
				
				Console.WriteLine("Please give us two integer numbers\n");
				Console.Write("First Number : ");
				int a = Convert.ToInt32(Console.ReadLine());
				
				Console.Write("Second Number: ");
				int b = Convert.ToInt32(Console.ReadLine());
				
				int ans = (a*a + b*b + 2*a*b);
				Console.WriteLine("\nWe calculated the two numbers through (First Number + Second Number)^2");
				Console.WriteLine("The answer is " + ans);
			
				if (a % 2 == 0) Console.WriteLine("The first number you entered, " + a + "  is an even number.");
				else Console.WriteLine("The first number you entered, " + a + "  is an odd number.");
				Console.WriteLine();
				
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