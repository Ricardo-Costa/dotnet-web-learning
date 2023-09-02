namespace MoqTest;

public class ClasseBase
{
    private readonly string _nome;

    public ClasseBase(string nome)
    {
        _nome = nome;
    }

    public virtual string GetNome()
    {
        return _nome;
    }
}

public class MinhaClasse : ClasseBase
{
    public MinhaClasse(string nome) : base(nome)
    {
    }

    public string GetSobrenome()
    {
        return "Sobrenome";
    }
}



public class Program
{
  public static void Main(string[] args)
  {
    Console.WriteLine("test");
  }
}