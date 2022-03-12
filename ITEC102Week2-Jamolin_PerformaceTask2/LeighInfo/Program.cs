/*
 * Created by SharpDevelop.
 * User: LEIGH
 * Date: 10/19/2021
 * Time: 8:59 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LeighInfo
{
	class Program
	{
		public static void Main(string[] args)
		{
			string name, gender, age, course, yearAndSection;
			
			Console.WriteLine("Please enter your information");
			Console.ReadLine();
			
			
			Console.Write("Name             : ");
			name = Console.ReadLine();
			
			Console.Write("Gender           : ");
			gender = Console.ReadLine();
			
			Console.Write("Age              : ");
			age = Console.ReadLine();
			
			Console.Write("Course           : ");
			course = Console.ReadLine();
			
			Console.Write("Year & Section   : ");
			yearAndSection = Console.ReadLine();
			
			// Display
			
			Console.WriteLine();
			Console.WriteLine("Hello! Here's the information we got from you.");
			Console.ReadLine();
			
			Console.Write("Your name is " + name + ", a " + gender);
			Console.ReadLine();
			
			Console.Write("You are " + age + " yrs. old");
			Console.ReadLine();
			
			Console.WriteLine("You are from " + course + " - " + yearAndSection);
			Console.ReadLine();
			

			Console.WriteLine("Press any key to continue . . .");
			Console.ReadKey(true);
		}
	}
}
