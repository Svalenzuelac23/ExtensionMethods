using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            var myName = "Marvin Valenzuela Contreras ?";
            

            Console.WriteLine(myName.LetterCount().ToString());
            Console.WriteLine(myName.WordCount().ToString());
            Console.ReadLine();
        }
    }
}
