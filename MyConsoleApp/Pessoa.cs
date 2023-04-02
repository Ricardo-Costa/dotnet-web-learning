namespace MyConsoleApp
{
    public abstract class Pessoa
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public virtual string Andar() // virutal permitirar ter sobrecarga de método
        {
            return $"{Nome} ou {this.Nome} está andando...";
        }
    }
}