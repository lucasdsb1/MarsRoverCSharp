using MarsRoverOFC.Types;

namespace MarsRoverOFC.Models;

public class Posicao
{
    public Posicao(int posicaoX, int posicaoY, char direcao)
    {
        X = posicaoX;
        Y = posicaoY;
        Direcao = direcao;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public char Direcao { get; set; }
}