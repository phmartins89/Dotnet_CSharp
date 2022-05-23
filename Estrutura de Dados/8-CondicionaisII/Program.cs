using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_CondicionaisII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando projeto 7 - Condicionais II");

            int idadeJoao = 18;
            int quantidadedePessoas = 2;

            bool acompanhado = quantidadedePessoas >= 2;


            if (idadeJoao >= 18 && acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }

            Console.ReadLine();
        }
    }
}
