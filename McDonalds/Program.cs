using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace McDonalds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cadastro de produtos
            Produto bigMac = new Produto("Big Mac", 29.90);
            Produto batataFrita = new Produto("Batata Frita", 12.00);
            Produto cocaCola = new Produto("Coca-Cola", 8.00);
            Produto bigTasty = new Produto("Big Tasty", 34.90);
            Produto mcLancheFeliz = new Produto("McLanche Feliz", 22.90);
            Produto mcFritasCheddarBacon = new Produto("McFritas Cheddar Bacon", 17.90);

            //Criação de pedidos
            Pedido pedido1 = new Pedido(1);
            pedido1.AdicionarItem(bigMac);
            pedido1.AdicionarItem(batataFrita);
            pedido1.AdicionarItem(bigTasty);
            pedido1.AdicionarItem(cocaCola);

            Pedido pedido2 = new Pedido(2);
            pedido2.AdicionarItem(cocaCola);
            pedido2.AdicionarItem(mcFritasCheddarBacon);
            pedido2.AdicionarItem(mcLancheFeliz);

            //Mostrar os pedidos
            pedido1.ExibirPedido();
            Console.WriteLine();
            pedido2.ExibirPedido();
        }
    }
}
