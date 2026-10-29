using dominio;

namespace TestesValidarMao;

public class DefinirVencedorTests
{
    [TestMethod]
    public void JogadorComCartaMaisAltaVence()
    {
        Mao mao1 = new("2O 3C 4E 5P 6O");
        Mao mao2 = new("2O 3C 4E 5P AO");

        DefinirVencedor.ValidarMaoJogadores(mao1, mao2);


    }
}