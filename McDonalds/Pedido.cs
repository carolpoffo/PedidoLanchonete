using System;
using System.Collections.Generic;

namespace McDonalds
{
    public class Pedido
    {
        public int NumeroPedido;

        public List<Produto> Produtos;

        public Pedido(int numeroPedido)
        {
            NumeroPedido = numeroPedido;
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.Preço;
            }
            return total;
        }

        public void ExibirPedido()
        {
            Console.WriteLine($"Pedido #{NumeroPedido}");
            Console.WriteLine("Itens:");
            foreach (var produto in Produtos)
            {
                Console.WriteLine($"- {produto.Nome} - R${produto.Preço:F2}"); 
            }
            Console.WriteLine($"Total: R${CalcularTotal():F2}");
            Console.WriteLine("");  
        }
    }
}
