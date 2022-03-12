/*
 * Created by SharpDevelop.
 * User: LEIGH
 * Date: 11/7/2021
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ITEC102Week4_Jamolin_EngagingActivity
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter your information\n");
			
			try
			{
				Console.Write("Name: ");
				string name = Console.ReadLine();
			
				Console.Write("City: ");
				string city = Console.ReadLine();
			
				Console.Write("Age : ");
				int age = Convert.ToInt32(Console.ReadLine());
			
				Console.Write("Pin : ");
				int pin = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("\n========================================");
				Console.WriteLine("Your Complete Address:");
				Console.WriteLine("========================================\n");
			
				Console.WriteLine("Name = " + name);
				Console.WriteLine("City = " + city);
				Console.WriteLine("Age  = " + age + " years old");
				Console.WriteLine("Pin  = " + pin);
			
				Console.WriteLine("\n========================================\n");
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