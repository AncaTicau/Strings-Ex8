using System;

namespace Strings_Ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            string infoEmily = SubsCharactersSet("Ana are mere si pere.", "ere");

            Console.WriteLine(infoEmily);

            Console.ReadKey();

        }

        //Write a method that strips a set of characters from a string.
        public static string SubsCharactersSet(string input, string charactersToRemove)
        {
            string result = input.Replace(charactersToRemove, "");

            return result;
        }

    }
}
