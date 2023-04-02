namespace MyConsoleApp
{
    public class Funcionario: Pessoa // TODO forma de fazer extends ou implements
    {
      // TODO Tipos ou membros internos são acessíveis somente em arquivos no mesmo assembly, como neste exemplo:
      internal protected int Matricula;

      public double Altura;

      public Funcionario(int matricula, string nome): base(nome: nome) // TODO Chamando o super constructor
      {
        Matricula = matricula;
        // Nome = nome;
      }

      public override string Andar()
      {
        return $"Funcionario anda rápido";
      }
    }
}