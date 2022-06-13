namespace MarsRoverOFC.Models;

public class Rover
{
    public Rover(Plator plator, Posicao posicao, List<char> movimentos)
    {
        Plator = plator;
        Posicao = posicao;
        Movimentos = movimentos;
    }
    
    public Plator Plator { get; set; }
    public Posicao Posicao { get; set; }
    public List<char> Movimentos { get; set; }
}