using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Downloadfolder_Organizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\Admin\Downloads";

            //sting[] means it is an array or a list of strings
            // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(rootPath, "*", SearchOption.TopDirectoryOnly);
            string[] folders = Directory.GetDirectories(rootPath, "*", SearchOption.TopDirectoryOnly);         

            Console.WriteLine("loop start");
            Console.WriteLine();
            Console.WriteLine("folders");
            Console.WriteLine("-------------------------------");
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }

            Console.WriteLine();
            Console.WriteLine("files");
            Console.WriteLine("-------------------------------");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("loop end");

            Console.ReadLine();
        }
    }
}
