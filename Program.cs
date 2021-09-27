using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule o índice de massa corporal de uma pessoa, dados altura (em m) e peso (em kg).

            Console.WriteLine("Calculadora IMC\n");

            Console.Write("Digite sua altura: ");
            float m = float.Parse(Console.ReadLine());

            Console.Write("Digite seu peso: ");
            float kg = float.Parse(Console.ReadLine());

            Console.WriteLine($"\nIMC: {kg/Math.Pow(m,2)} kg/m²");
        }
    }
}
