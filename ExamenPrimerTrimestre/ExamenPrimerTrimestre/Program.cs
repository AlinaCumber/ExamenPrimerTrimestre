using System;

namespace ExamenPrimerTrimestre
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Examen.MetrosToMillas());
            //Examen.CelciusToFahrenheit(20);
            //Examen.PositiveOrNegative();
            //Console.WriteLine(Examen.GreatNumberOfThree()); 
            //Examen.PrintNumbers();
            //Examen.SumOfNumber();

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i > 0; i--)
            {
                if (a % i == 0 && b % i == 0)
                {                    
                        Console.WriteLine(i);                       
                    
                }
            }


        }

    }
}
