using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnimi pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit");



        }
    }
}
