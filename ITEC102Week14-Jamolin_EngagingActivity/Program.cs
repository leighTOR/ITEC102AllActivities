using System;
using System.IO;
using System.Text;

// I'm using VS 2022
namespace ITEC102Week14_Jamolin_EngagingActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the variables for paths, and date and time
            DateTime dt = DateTime.Now;
            string date = dt.ToString("yyyy-MM-dd");
            string time = dt.ToString("hh:mm:ss tt");
            string fsPath = @"D:\FPAct8_Jamolin\UsingFileStream.txt";
            string swPath = @"D:\FPAct8_Jamolin\UsingStreamWriter.txt";
            string twPath = @"D:\FPAct8_Jamolin\UsingTextWriter.txt";

            // Writing in text file using FileStream Class
            FileStream fs = new FileStream(fsPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            byte[] bdata = Encoding.Default.GetBytes($"Date: {date}\nTime: {time}");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();

            // reading fsPath
            using (StreamReader sr = new StreamReader(fsPath))
            {
                Console.WriteLine("Content of UsingFileStream.txt");
                string data = "";
                while ((data = sr.ReadLine()) != null)
                {
                    Console.WriteLine(data);
                }
            }

            // using StreamWriter
            using (StreamWriter sw = new StreamWriter(swPath))
            {
                sw.WriteLine($"Date: {date}\nTime: {time}");
                sw.Close();
            }

            // using StreamReader to read swPath
            using (StreamReader sr = new StreamReader(swPath))
            {
                Console.WriteLine("\nContent of UsingStreamWriter.txt");
                Console.WriteLine(sr.ReadToEnd());
            }

            // using TextWriter
            using (TextWriter tw = File.CreateText(twPath))
            {
                tw.WriteLine($"Date: {date}\nTime: {time}");
                tw.Close();
            }

            // using TextReader to read twPath
            using (TextReader tr = File.OpenText(twPath))
            {
                Console.WriteLine("Content of UsingTextWriter.txt");
                Console.WriteLine(tr.ReadToEnd());
            }

            Console.Write("Press any key to exit the program...");
            Console.ReadKey(true);
        }
    }
}