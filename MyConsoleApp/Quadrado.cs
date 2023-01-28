namespace MyConsoleApp
{
    public struct Quadrado
    {
        public double Largura;
        public double Altura;

        public Quadrado(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Largura * Altura;
        }
    }
}