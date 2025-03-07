using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace McDonalds
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            List<Produto> cardapio = new List<Produto>();

            Produto coca = new Produto();
            coca.Nome = "Coca-Cola";
            coca.Preco = 5.50;
            cardapio.Add(coca);

            Pedido pedido = new Pedido();
            pedido.NumeroPedido = 1;
            Console.WriteLine("Digite o produto que deseja");
            MostrarCardapio(cardapio)
            int op = int.Parse(Console.ReadLine());

            static void MostrarCardapio(List<Produto> cardapio)
            {
                foreach (Produto produto in cardapio)
                {
                    produto.Mostrar();
                }
            }

            Produto BigMac = new Produto("BigMac", 29.90);
            Produto McChicken = new Produto("McChicken", 24.90);
            Produto BigTasty = new Produto("BigTasty", 32.90);
            Produto BatataFrita = new Produto("Batata Frita", 15.90);
            Produto CocaCola = new Produto("Coca-Cola 500ml", 9.90);

            Pedido pedido1 = new Pedido(1);
            pedido1.AdicionarProduto(BigMac);
            pedido1.AdicionarProduto(BatataFrita);
            pedido1.AdicionarProduto(CocaCola);

            Pedido pedido2 = new Pedido(2);
            pedido2.AdicionarProduto(McChicken);
            pedido2.AdicionarProduto(CocaCola);
            pedido2.AdicionarProduto(BigTasty);

            Pedido pedido3 = new Pedido(3);
            pedido3.AdicionarProduto(BigTasty);
            pedido3.AdicionarProduto(BigMac);
            pedido3.AdicionarProduto(BatataFrita);
            pedido3.AdicionarProduto(CocaCola);
            pedido3.AdicionarProduto(McChicken);

            pedido1.ExibirPedido();
            pedido2.ExibirPedido();
            pedido3.ExibirPedido();
        }
    }
}
