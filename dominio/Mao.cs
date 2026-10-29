namespace dominio;

public class Mao
{
    public List<Carta> Cartas = new ();

    public Par? ehPar 
    public Trinca? ehTrinca

    public Mao(string sequenciaCartas)
    {
        var cartasSeparadas = sequenciaCartas.Split(" ");

        foreach(string carta in cartasSeparadas)
            Cartas.Add(new Carta(carta));
    }
}