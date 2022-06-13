using MarsRoverOFC.Models;
using MarsRoverOFC.Services.Interfaces;
using MarsRoverOFC.Types;

namespace MarsRoverOFC.Services;

public class RoverService : IRoverService
{
    public Rover ExecutarMovimentos(Rover rover)
    {
        //Sugestão do ReSharper
        return rover.Movimentos.Aggregate(rover, (current, comando) => comando.ToString() switch
        {
            MovimentoType.Esquerda => VirarParaEsquerda(rover),
            MovimentoType.Direita => VirarParaDireita(rover),
            MovimentoType.Frente => MoverParaFrente(rover),
            _ => current
        });

        //É a mesma coisa que isso aqui
        //return rover.Movimentos.Aggregate(rover, (current, comando) => comando.ToString() switch
        //{
        //    MovimentoType.Esquerda => VirarParaEsquerda(rover),
        //    MovimentoType.Direita => VirarParaDireita(rover),
        //    MovimentoType.Frente => MoverParaFrente(rover),
        //    _ => current
        //});
    }

    private static Rover VirarParaEsquerda(Rover rover)
    {
        rover.Posicao.Direcao = char.Parse(MovimentoType.Esquerda);
        return rover;
    }
    
    private static Rover VirarParaDireita(Rover rover)
    {
        rover.Posicao.Direcao = char.Parse(MovimentoType.Direita);
        return rover;
    }

    private static Rover MoverParaFrente(Rover rover)
    {        
        rover.Posicao = FazerMovimento(rover.Posicao, rover.Plator);
        return rover;
    }

    private static Posicao FazerMovimento(Posicao posicao, Plator plator)
    {
        var novaPosicao = posicao.Direcao.ToString() switch
        {
            DirecaoType.Norte => new Posicao(posicao.X, posicao.Y + 1, posicao.Direcao),
            DirecaoType.Sul => new Posicao(posicao.X, posicao.Y - 1, posicao.Direcao),
            DirecaoType.Leste => new Posicao(posicao.X + 1, posicao.Y, posicao.Direcao),
            DirecaoType.Oeste => new Posicao(posicao.X - 1, posicao.Y, posicao.Direcao),
            _ => posicao
        };

        return novaPosicao.X < 0 || novaPosicao.X > plator.X || novaPosicao.Y < 0 || novaPosicao.Y > plator.Y
            ? posicao
            : novaPosicao;
    }
}