using dominio;
using dominio.enums;

namespace TestesValidarMao;

[TestClass]
public class CartasTests
{
    [TestMethod]
    public void AdicionarCarta4RetornaValor01()
    {
        Carta carta = new("4O");

        carta.PegarValor();

        Assert.AreEqual(4, carta.Valor);
    }

    [TestMethod]
    public void AdicionarCarta9RetornaValor09()
    {
        Carta carta = new("9O");

        carta.PegarValor();

        Assert.AreEqual(9, carta.Valor);
    }

    [TestMethod]
    public void AdicionarCarta6RetornaValor06()
    {
        Carta carta = new("6O");

        carta.PegarValor();

        Assert.AreEqual(6, carta.Valor);
    }

    [TestMethod]
    public void AdicionarCartaKRetornaValor13()
    {
        Carta carta = new("KO");

        carta.PegarValor();

        Assert.AreEqual(13, carta.Valor);
    }

    [TestMethod]
    public void AdicionarCartaARetornaValor14()
    {
        Carta carta = new("AO");

        carta.PegarValor();

        Assert.AreEqual(14, carta.Valor);
    }
    [TestMethod]
    public void Carta4Operde5O()
    {
        Carta carta = new("4O");
        Carta cartaAdversaria = new("5O");

        Resultado resultado =carta.CartaGanhou(cartaAdversaria);

        Assert.AreEqual(Resultado.Derrota, resultado);

    }

    [TestMethod]
    public void Carta9Pganha7P()
    {
        Carta carta = new("9P");
        Carta cartaAdversaria = new("7P");

        Resultado resultado = carta.CartaGanhou(cartaAdversaria);

        Assert.AreEqual(Resultado.Venceu, resultado);

    }

    [TestMethod]
    public void CartaKPganha7P()
    {
        Carta carta = new("KP");
        Carta cartaAdversaria = new("7P");

        Resultado resultado = carta.CartaGanhou(cartaAdversaria);

        Assert.AreEqual(Resultado.Venceu, resultado);
    }

    [TestMethod]
    public void CartaAPganha2P()
    {
        Carta carta = new("AP");
        Carta cartaAdversaria = new("2P");

        Resultado resultado =carta.CartaGanhou(cartaAdversaria);

        Assert.AreEqual(Resultado.Venceu, resultado);
    }
}