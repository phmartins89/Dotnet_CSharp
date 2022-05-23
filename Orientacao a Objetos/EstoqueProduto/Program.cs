using System;
using System.Globalization;

namespace EstoqueProduto{
    class Program{
        static void Main(string[] args){

            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine(); // LER UMA STRING
            Console.WriteLine("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // LER UM DOUBLE
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine()); // LER UM INT

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produto a ser adicionado: ");
            int qte = int.Parse(Console.ReadLine());            
            p.AdicionarProdutos(qte); 

            Console.WriteLine();  
            Console.WriteLine("Dados atualizados: "+p);


            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido: ");
            qte = int.Parse(Console.ReadLine());            
            p.RemoverProdutos(qte);

            Console.WriteLine();  
            Console.WriteLine("Dados atualizados: "+p);

        }
    }
}