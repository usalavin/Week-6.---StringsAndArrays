using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab mis kasutajaga juhtub homme (kasutame random klassi)
            string[] predictions = { "win a milliom", "fall in love", "buy youtube premium", "join darkside for cookies" };
            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);

            Console.WriteLine($"Tomorrow you will {predictions[userNumber]}");
        }
       
        
    }
}
