namespace MyConsoleApp
{
    public class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Andar()
        {
            return $"{Nome} ou {this.Nome} está andando...";
        }
    }
}