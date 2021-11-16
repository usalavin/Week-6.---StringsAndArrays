using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikkem, kas ees- või perekonnanimi


            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Sisesta perekonnanimi:");

            string lastName = Console.ReadLine();

            //int firstNameLenght = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit ja perekonnanimes on {lastName.Length}");
            string pikkemSõna = Console.ReadLine();

            if (lastName.Length > firstName.Length)
            {
                Console.WriteLine("Sinu perekonnanimi on pikkem kui eesnimi.");
            }
            if (firstName.Length > lastName.Length)
            {
                Console.WriteLine("Sinu eesnimi on pikkem kui perekonnanimi.");
                
            }
         if (firstName.Length == lastName.Length)
            
            {
                Console.WriteLine("Sinu ees- ja perekonnanimes on võrdne sümbolite arv");
            }
        
               

        }
    }
}
