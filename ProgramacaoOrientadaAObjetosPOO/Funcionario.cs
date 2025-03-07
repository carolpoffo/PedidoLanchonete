using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOrientadaAObjetosPOO
{
    public class Funcionario
    {
        public string Nome;
        public string Cargo;
        public double Salario;

        public void Print()
        {
            Console.WriteLine($"Funcionário ---------");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario}");
            Console.WriteLine($"Salário Líquido: {SalarioLiquido()}");
            Console.WriteLine("");
        }

        public double SalarioLiquido()
        {
            if (Cargo == "Estagiario")
            {
                return SalarioLiquidoEstagiario();
            }
            return SalarioLiquidoCLT();
        }

        public double SalarioLiquidoEstagiario()
        {
            return Salario;
        }

        public double SalarioLiquidoCLT()
        {
            return Salario * 0.725;
        }

    }
}
