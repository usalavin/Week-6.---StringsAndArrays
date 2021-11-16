using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu "h", "o" ja "l" on lauses "Hello World!"




            string tekst = "Hello World!";

            string HelloWorld = $"{tekst}".ToLower();


            


            int hCounter = 0;
            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'h')
                {
                    hCounter++;
                }

            }

            if (hCounter != 1)
            {
                Console.WriteLine($"Selles tekstis on {hCounter} 'h' tähte. ");

            }
            else
            {
                Console.WriteLine($"Selles tekstis on {hCounter} 'h' täht. ");

            }


            int oCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'o')
                {
                    oCounter++;
                }

            }
            if (oCounter != 1)
            {
                Console.WriteLine($"Selles tekstis on {oCounter} 'o' tähte. ");

            }
            else
            {
                Console.WriteLine($"Selles tekstis on {oCounter} 'o' täht. ");

            }

            int lCounter = 0;

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'l')
                {
                    lCounter++;
                }

            }
            if (lCounter != 1)
            {
                Console.WriteLine($"Selles tekstis on {lCounter} 'l' tähte. ");

            }
            else
            {
                Console.WriteLine($"Selles tekstis on {lCounter} 'l' täht. ");

            }

            for (int i = 0; i < HelloWorld.Length; i++)
            {
                if (HelloWorld[i] == 'h')
                {
                    hCounter++;
                }

            }

        }   
    }
}