using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC102Week14_Jamolin_PerformanceTask
{
    internal class Menu
    {
		// encapsulated fields and properties
		private List<string> bmName { get; set; } = new List<string>();
		private List<string> iColor { get; set; } = new List<string>();
		private List<int> iContent { get; set; } = new List<int>();

		// parameters and constructors for the menu class
		public Menu(List<string> bmName, List<string> iColor, List<int> iContent)
		{
			this.bmName = bmName;
			this.iColor = iColor;
			this.iContent = iContent;
		}

		// below are the method associated with menu
		// add option
		public void Add()
		{
			Console.Write("Input boardMarker name: ");
			bmName.Add(Console.ReadLine());
			Console.Write("Input inkColor: ");
			iColor.Add(Console.ReadLine());
			Console.Write("Input inkContent: ");
			iContent.Add(Convert.ToInt32(Console.ReadLine()));
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("INFORMATION successfully saved!");
			Console.ResetColor();
		}

		// search option
		public void Search()
		{
			Console.Write("Enter the bm number: ");
			int index = Convert.ToInt32(Console.ReadLine());
			index--; // this is to minus 1 the index
			Console.WriteLine($"Boardmarker name: {bmName[index]}");
			Console.WriteLine($"inkColor: {iColor[index]}");
			Console.WriteLine($"inkContent: {iContent[index]}");
		}

		// view all option
		public void ViewAll()
		{
			int num = 1;
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WriteLine("Num\tName\tColor\tContent");
			Console.ResetColor();
			for (int i = 0; i < bmName.Count; i++)
			{
				Console.WriteLine($"{num}\t{bmName[i]}\t{iColor[i]}\t{iContent[i]}");
				num++;
			}
		}

		// exit option
		public void Exit()
		{
			Console.Write("Press any key to exit the program...");
			Console.ReadKey(true);
		}
	}
}