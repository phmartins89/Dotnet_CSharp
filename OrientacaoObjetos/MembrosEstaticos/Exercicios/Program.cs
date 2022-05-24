using System;
using System.Globalization;

namespace Exercicios{
    class Program{
        static void Main(string[] args){


            Console.WriteLine("Qual é a cotação do dolar?: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai comprar?: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConversorDeMoeda.DolarParaReal(quantia,cotacao);        
            
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
        
    }
}