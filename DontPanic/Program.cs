﻿using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses 4-ga

            string dontp = "Don't panic";

            
            dontp = dontp.Replace('o', '0');
            dontp = dontp.Replace('a', '4');
            Console.WriteLine(dontp);
        }
    }
    }

