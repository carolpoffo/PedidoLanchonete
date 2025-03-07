namespace ProgramacaoOrientadaAObjetosPOO
{
    internal class Program
    {
        //Classe é um modelo da vida real
        //Nomear uma classe com substantivo (pessoa, carro) nunca uma ação
        //Classes são estruturas que definem as propriedades e comportamentos de um tipo de objeto
        //Quando é static não precisa do objeto estanciado, que não é static precisa do objeto estanciado
        static void Main(string[] args)
        {
            Funcionario estagiario = new Funcionario();
            estagiario.Nome = "Carol";
            estagiario.Cargo = "Estagiario";
            estagiario.Salario = 2000;
            estagiario.Print();

            Funcionario gestor = new Funcionario();
            gestor.Nome = "João";
            gestor.Cargo = "Gestor";
            gestor.Salario = 15000;
            gestor.Print();
        }
    }
}