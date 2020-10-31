using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //variabile initializate cu 0
            double num1 = 0, num2 = 0;

            
            Console.WriteLine("Calculator in C#\r");
            Console.WriteLine("-----------\n");
            
            // introducere nr 1
            Console.WriteLine("Introdu primul numar si apasa Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            //introducere nr 2
            Console.WriteLine("Introdu al 2-lea numar si apasa Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            //selectare optiune de calcul
            Console.WriteLine("Alege una din urmatoarele optiuni");
            Console.WriteLine("\ta - Adunare");
            Console.WriteLine("\ts - Scadere");
            Console.WriteLine("\tm - Inmultire");
            Console.WriteLine("\td - Impartire");
            
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Rezultatul: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Rezultatul: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Rezultatul: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while(num2==0)
                    {
                        Console.WriteLine("Nu se poate divide cu 0");
                        Console.WriteLine("Introdu alt numar ca divizor");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine($"Rezultatul: {num1} / {num2} = " + (num1 / num2));
                    break;

            }
            //comanda de la user ca sa se inchida aplicatia
            Console.WriteLine("Apasa orice tasta pentru a inchide calculatorul");
            Console.ReadKey();



        }
    }
}
