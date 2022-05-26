using System;
using System.Globalization;

namespace EstoqueProdutoConstrutores{
    class Program{
        static void Main(string[] args){


            Console.WriteLine("Entre os dados do produto: ");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine(); // LER UMA STRING
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // LER UM DOUBLE
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine()); // LER UM INT

            Produto p = new Produto(nome,preco); // Construtor

            Produto p2 = new Produto{ //Outra forma de estanciar o construtor
                Nome = "Tv",
                Preco = 500.00,
                Quantidade = 20
            };

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