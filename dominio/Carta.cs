using dominio.enums;

namespace dominio;

public class Carta
{
    public string Numero {get; private set;}= string.Empty;
    public string Naipe {get; private set;}=  string.Empty;
    public int Valor {get; private set;}
    
    public Carta(string input)
    {   
        Numero = input.Substring(0, 1).ToUpper();
        Naipe = input.Substring(1, 1);
        Valor = PegarValor();
    }
    public Resultado CartaGanhou(Carta cartaAdversaria)
    {
        if(Valor > cartaAdversaria.Valor)
            return Resultado.Venceu;
        else if(Valor < cartaAdversaria.Valor) 
            return Resultado.Derrota;

        return Resultado.Empate;
    }
    public int PegarValor()
    {
        switch (Numero)
        {
            case "2":
                return 2;

            case "3":
                return 3;

            case "4":
                return 4;

            case "5":
                return 5;

            case "6":
                return 6;

            case "7":
                return 7;

            case "8":
                return 8;

            case "9":
                return 9;
            case "D":
                return 10;

            case "J":
                return 11;

            case "Q":
                return 12;

            case "K":
                return 13;

            case "A":
                return 14;
            
            default:
                throw new NotSupportedException("Cartas Invalidas!");
        }
    }

        // public List<string> CartasJogador = [
    //     "2O", "2C","2E", "2P",
    //     "3O", "3C","3E", "3P",
    //     "4O", "4C","4E", "4P",
    //     "5O", "5C","5E", "5P",
    //     "6O", "6C","6E", "6P",
    //     "7O", "7C","7E", "7P",
    //     "8O", "8C","8E", "8P",
    //     "9O", "9C","9E", "9P",
    //     "DO", "DC","DE", "DP",
    //     "JO", "JC","JE", "JP",
    //     "QO", "QC","QE", "QP",
    //     "KO", "KC","KE", "KP",
    //     "AO", "AC","AE", "AP",
    //     ];
}