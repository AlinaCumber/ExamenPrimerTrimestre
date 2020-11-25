using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerTrimestre
{
    class Examen
    {
        public static float MetrosToMillas()
        {
            float cantidadParaConvert = 3000;
            float UnMilla = 1609;
            float millas = cantidadParaConvert / UnMilla;
            return millas;

        }

        public static void CelciusToFahrenheit(float cel)
        {
            float kelvin = cel + 273;
            float fahrenheit = cel * 18 / 10 + 32;
            Console.WriteLine(kelvin + " " + fahrenheit);
        }

        public static void PositiveOrNegative()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if(number1 >= 0 || number2 >= 0)
            {

               if (number1 >= 0 && number2 >= 0)
                {
                    Console.WriteLine("Los dos numberos son positivo");
                }  
               else
                    Console.WriteLine("Uno de los numeros es positivo");           
               
            }         

            else
                Console.WriteLine("Los dos son negativos");

        }

        public static int GreatNumberOfThree()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
                return number1;
            else if (number2 > number1 && number2 > number3)
                return number2;
            else
                return number3;
        }

        public static void PrintNumbers()
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            switch (number1)
            {
                case 1: 
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                default:
                    Console.WriteLine("Este numero no esta en rango de 1 a 5");
                    break;
            }
        }

        public static void SumOfNumber()
        {       
            
            int sum = 0;


            while (true)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                sum += number;
                
                Console.WriteLine(sum);
                if (number == 0 || number < 0)
                    break;
            }
        }
    }
}
