using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Execuntando projeto 9 - Escopo");

            int idadeJoao = 18;
            int quantidadedePessoas = 2;
            bool acompanhado = true;
            string mensagemAdicional;

            if (acompanhado == true)
            {
                mensagemAdicional = "joao esta acompanhado!";
            }
            else
                mensagemAdicional = "joao NAO esta acompanhado!";


            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar!");
                Console.WriteLine(mensagemAdicional);
            }
            else
                Console.WriteLine("Não pode entrar!");


            Console.ReadLine();
        }
    }
}
