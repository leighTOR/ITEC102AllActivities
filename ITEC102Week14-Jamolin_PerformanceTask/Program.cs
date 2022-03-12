using System;
using System.IO;

// I'm using Visual Studio 2022
namespace ITEC102Week14_Jamolin_PerformanceTask
{
    class Program
    {
        static void Main (string[] args)
        {
			try
			{
				// I used list instead of array since it's more suitable
				List<string> bmName = new List<string>();
				List<string> iColor = new List<string>();
				List<int> iContent = new List<int>();

				// instance of the class Menu with arguments
				Menu menu = new Menu(bmName, iColor, iContent);

				int i = 1;
				while (i >= 1) // to loop until there's no more items left or when it reaches the break
				{
					// menu that will be displayed to the user
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("==MENU==");
					Console.WriteLine("[A]DD\n[S]EARCH\n[V]IEW ALL\n[E]XIT");
					Console.ResetColor();
					Console.Write("Enter your choice: ");
					char c = Convert.ToChar(Console.ReadLine().ToUpper()); // incase the user used lowercase
					Console.WriteLine();

					// to call out the method according to the choice
					if (c.Equals('A'))
						menu.Add();
					else if (c.Equals('S'))
						menu.Search();
					else if (c.Equals('V'))
						menu.ViewAll();
					else
					{
						if (c.Equals('E'))
						{
							menu.Exit();
							break;
						}
						Console.WriteLine("Error. Wrong input.");
					}
					i++;
					Console.WriteLine();
				}

				// this is to store data in the text file
				FileStream fs = new FileStream(@"D:\FPAct8_Jamolin\Jamolin_BoardMarker.txt", FileMode.Create);
				using (StreamWriter sw = new StreamWriter(fs))
				{
					int num = 1;
					for (i = 0; i < bmName.Count; i++)
					{
						sw.WriteLine($"Boardmarker number: {num}");
						sw.WriteLine($"Boardmarker name: {bmName[i]}");
						sw.WriteLine($"inkColor: {iColor[i]}");
						sw.WriteLine($"inkContent: {iContent[i]}");
						sw.WriteLine();
						num++;
					}
					sw.Close();
				}
				fs.Close();
			}
			catch (Exception ex) // so that the error would be catch
            {
				Console.WriteLine(ex.Message);
            }
		}
    }
}