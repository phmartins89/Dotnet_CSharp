using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            //ContaCorrente é a Classe(planta do apto)
            //ContaGabriela é o Objeto(Os móveis do apto)

            // ContaCorrente XXXXXXXXX = new ContaCorrente();  termo para criação de um Objeto e apontamento de referencia na memoria

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));

            int idade = 32;
            int idadeMaisUmaVez = 32;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));


            contaDaGabriela = contaDaGabrielaCosta; // contaDaGabriela RECEBE A REFERECNIA contaDaGabrielaCosta, agora contaDaGabrielaCosta APONTA PARA contaDaGabriela

            Console.WriteLine("Igualdade de tipo de referencia: " + (contaDaGabriela == contaDaGabrielaCosta));


            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);

           

            Console.ReadLine();

        }
    }
}
