using System;
namespace RaioCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Quantos números inteiros vc vai digitar?");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;
            for (int i = 1; i <= N; i++)
            {
                System.Console.WriteLine("Valor: #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma += valor;
            }
                System.Console.WriteLine("Soma = " + soma);
                
        }
    }
}