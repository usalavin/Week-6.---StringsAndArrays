using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "Hello world" tagurpidi

            string tekst = "Hello World!";
            string HelloWorld = $"{tekst}".ToLower();
            string firstName = Console.ReadLine();

            for (int i = HelloWorld.Length - 1; i >= 0; i--)
            {
                Console.Write(HelloWorld[i]);

            }
        }

    }
}


