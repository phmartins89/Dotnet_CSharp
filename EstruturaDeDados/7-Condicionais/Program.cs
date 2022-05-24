using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantidadedePessoas = 2;

            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade");
            }
            else
            {
                if (quantidadedePessoas >= 2)
                {
                    Console.WriteLine("João tem menos de 18 anos, mas está acompanhado.");
                }
                else
                {
                    Console.WriteLine("João tem menos de 18 anos e desacompanhado.");
                }
            }
            Console.ReadLine();
        }
    }
}
