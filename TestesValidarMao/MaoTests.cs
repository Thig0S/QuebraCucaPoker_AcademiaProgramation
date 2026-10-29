using dominio;

namespace TestesValidarMao;

[TestClass]
public class MaoTests
{
    [TestMethod]
    public void CriarMaoNaoRetornaErros_E_Rertona5Cartas()
    {
        Mao mao = new("5C 5P 6E 7P K0");

        Assert.AreEqual(5, mao.Cartas.Count());
    }
}