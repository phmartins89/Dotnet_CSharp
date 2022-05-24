using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando projeto 9 - Escopo");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido += valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + " mês, voce terá R$" + valorInvestido);
                contadorMes++;
            }


            ////0.36% = 0,0036
            //valorInvestido += valorInvestido * 0.0036;
            //Console.WriteLine("Após 1 mês, voce terá R$" + valorInvestido);

            //valorInvestido += valorInvestido * 0.0036;
            //Console.WriteLine("Após 2 mês, voce terá R$" + valorInvestido);


            Console.ReadLine();
        }
    }
}
