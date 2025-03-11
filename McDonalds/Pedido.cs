using System;
using System.Collections.Generic;

namespace McDonalds
{
    class Pedido
    {
        public int Numero { get; set; }
        public List<Produto> Itens { get; set; }

        public Pedido(int numero)
        {
            Numero = numero;
            Itens = new List<Produto>();
        }

        public void AdicionarItem(Produto produto)
        {
            Itens.Add(produto);
        }

        public double CalcularTotal()
        {
            double total = 0;
            foreach (var produto in Itens)
            {
                total += produto.Preco;
            }
            return total;
        }

        public void ExibirPedido()
        {
            Console.WriteLine($"Pedido #{Numero}");
            Console.WriteLine("Itens:");
            foreach (var produto in Itens)
            {
                Console.WriteLine($"- {produto}");
            }
            Console.WriteLine($"Total: R${CalcularTotal():F2}");
        }
    }
}