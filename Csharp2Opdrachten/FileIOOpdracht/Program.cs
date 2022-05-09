using System;
using System.IO;
// to get assembly info of the dll location for local directory-traversing
using System.Reflection;

namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo assemblyDir = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory;
            string pathToBase = @"..\..\..\";
            // get the base directory of the project
            DirectoryInfo BaseDir = new DirectoryInfo(Path.Combine(assemblyDir.ToString(), pathToBase));
            string outputDir = @"./output/";

            // create the file we are going to read later
            StreamWriter createFile = File.CreateText(BaseDir + "Readfile.txt");
            createFile.WriteLine("Dit is een regel");
            createFile.WriteLine("Dit is óók een regel");
            createFile.WriteLine("Het heeft zelfs 3 regels!");
            createFile.WriteLine("Nee toch 4");
            // close the file so we can read it later
            createFile.Close();


            // read the file 
            string[] fileLines = File.ReadAllLines(BaseDir + "Readfile.txt");
            foreach(string line in fileLines)
            {
                Console.WriteLine(line);
            }


            // wait for user input
            string input = Console.ReadLine();
            // create a new file at the output directory
            StreamWriter createOutput = File.CreateText(Path.Combine(BaseDir.ToString(), outputDir, "output.txt"));
            foreach(string line in fileLines)
            {
                createOutput.WriteLine(line);
            }
            createOutput.WriteLine(input);
            createOutput.Close();
        }
    }
}
