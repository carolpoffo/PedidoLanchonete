using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace McDonalds
{
    public class Produto
    {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preco = preço;
        }

        public void Mostrar()
        {
            Console.WriteLine($"{Nome} - {Preco}");
        }
    }
}

