using System;

namespace Modulo4
{
    public class Ficha7Solucao
    {
        #region Ex1
        public static void Exercicio1()
        {
            Console.WriteLine("Qual é a nota:");
            double nota = double.Parse(Console.ReadLine());
            if (nota >= 9.44)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.WriteLine("Passou!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

            }   
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Chumbou!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            
        }
        #endregion
        #region Ex2
        public static double Exercicio()
        {
            Console.WriteLine("Qual é a altura em Kg?");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o peso em Kg?");
            double weight = double.Parse(Console.ReadLine());
            double bmi = CalcBMI(height, weight);
        }
        private static void CalcBMI(double height, double weight)
        {
            var bmi = (weight) / (height * height);
            return bmi;
        }
        #endregion
    }
}
