using Moq;
using Xunit;
using MoqTest;

namespace MoqTest.Unit;

public class MinhaClasseTest
{
    [Fact]
    public void TesteComMock()
    {
        // Configuração do mock da classe derivada
        var mockMinhaClasse = new Mock<MinhaClasse>("NomeDeExemplo");

        // Exemplo de configuração de método da classe derivada
        mockMinhaClasse.Setup(x => x.GetSobrenome()).Returns("SobrenomeModificado");

        // Crie uma instância da classe de teste que usa o mock
        var minhaClasse = mockMinhaClasse.Object;

        // Execute o teste
        var resultadoSobrenome = minhaClasse.GetSobrenome();
        var resultadoNome = minhaClasse.GetNome();

        // Verifique se o mock funcionou
        Assert.Equal("SobrenomeModificado", resultadoSobrenome);
        Assert.Equal("NomeDeExemplo", resultadoNome);
    }
}
