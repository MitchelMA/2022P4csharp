using System;

namespace EnumsOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            // write the different colors
            Colors[] ColorsArr = (Colors[])typeof(Colors).GetEnumValues();
            foreach(Colors color in ColorsArr)
            {
                Console.WriteLine(color);
            }

            // user input
            string value = Console.ReadLine();
            Colors parsedColor;
            try
            {
                parsedColor = (Colors)Enum.Parse(typeof(Colors), value);
                Console.WriteLine($"{parsedColor}: {(int)parsedColor}");
            } catch(Exception _)
            {
                Console.WriteLine("Dat is geen kleur");
            }
        }
    }
 
    internal enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow
    }
}
