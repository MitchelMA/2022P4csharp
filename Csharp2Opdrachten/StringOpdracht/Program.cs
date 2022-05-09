using System;
using System.IO;
using System.Reflection;

namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            // get the assembly dir
            DirectoryInfo assemblyDir = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory;
            // path to the base of the project
            string pathToBase = @"..\..\..\";
            // get the info of this directory
            DirectoryInfo baseDir = new DirectoryInfo(Path.Combine(assemblyDir.ToString(), pathToBase));

            FileInfo file = new FileInfo(baseDir + "stringsplit.txt");
            StreamReader read = file.OpenText();
            string text = read.ReadToEnd();
            Console.WriteLine(text);

            // remove all the ',' at the end of the text recursively
            text = RemoveTrail(text);
            // remove all the unnecessary in-between whitespaces
            text = text.Replace(' ', '\0');
            Console.WriteLine(text);

            // split the string to get the data
            string[] vakken = text.Split(':')[1].Split(',');
            foreach(string vak in vakken)
            {
                try
                {
                    string[] vakData = vak.Split('=');
                    Console.WriteLine($"{vakData[0]}: {vakData[1]}");
                }
                catch (Exception _) { }
            }
        }
        internal static string RemoveTrail(string input)
        {
            if(input.EndsWith(',') || input.EndsWith('.'))
            {
                input = input.Remove(input.Length - 1);
                return RemoveTrail(input);
            }
            return input;
        }
    }
}
    