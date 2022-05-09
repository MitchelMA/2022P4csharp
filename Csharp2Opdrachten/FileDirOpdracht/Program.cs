using System;
using System.IO;
using System.Reflection;

namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the current running assembly
            string location = Assembly.GetExecutingAssembly().Location;
            // path to running dir
            string path = @"..\..\..\..\";
            string combined = Path.Combine(location, path);
            DirectoryInfo info = new DirectoryInfo(combined);

            getDirs(info);
            
        }
        internal static void getDirs(DirectoryInfo parentDir, int depth = 0)
        {
            // print files in the directory
            foreach(FileInfo file in parentDir.GetFiles())
            {
                string depthString = "";
                for(int i = 0; i < depth + 0; i++)
                {
                    depthString += " ";
                }
                Console.WriteLine(depthString + file.Name);
            }

            // recursive directory display
            foreach(DirectoryInfo dir in parentDir.GetDirectories())
            {
                string depthString = "";
                for(int i = 0; i < depth; i++)
                {
                    depthString += " ";
                }
                Console.WriteLine(depthString + dir.Name + "/");
                getDirs(dir, depth + 1);
            }
        }
    }
}
