using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace EstoqueProduto {
    class Produto {
        
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValoreTotalEmEstoque(){ //METODOS
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){ //QUANDO É VARIAVEL DE PARAMETRO DE ENTRADA O PADRAO É LETRA MINUSCULA
            Quantidade += quantidade;
        }


        public void RemoverProdutos(int quantidade){ //QUANDO É VARIAVEL DE PARAMETRO DE ENTRADA O PADRAO É LETRA MINUSCULA
            Quantidade -= quantidade;
        }

        public override string ToString() //OVERRIDE É UMA OPERAÇAO DE OUTRA CLASE A OBJETCT
        { 
            return Nome //REAPROVIETAMENTO DE CÓDIGO EM CONCATENAÇÃOs
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValoreTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}