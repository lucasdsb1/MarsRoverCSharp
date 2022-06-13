using MarsRoverOFC.Models;
using MarsRoverOFC.Services.Interfaces;
using MarsRoverOFC.Types;

namespace MarsRoverOFC.Services;

public class PosicaoService : IPosicaoService
{
    public Posicao ConverterParaPosicao(string posicaoInicial, Plator plator)
    {
        try
        {
            var entradas = posicaoInicial.Split(" ");

            if (entradas.Length != 3)
            {
                throw new Exception("Tamanho inválido");
            }

            Posicao posicao;

            if (int.TryParse(entradas[0], out var x) && int.TryParse(entradas[1], out var y) && char.TryParse(entradas[2].ToUpper(), out var direcao))
            {
                posicao = new Posicao(x, y, ValidarDirecao(direcao));
            }
            else
            {
                throw new Exception("Não foi possível converter a entrada para posição!");
            }

            if (posicao.X < 0 || posicao.X > plator.X || posicao.Y < 0 || posicao.Y > plator.Y)
            {
                throw new Exception("Posição negativa ou maior que o plator!");
            }

            return posicao;
        }
        catch (Exception ex)
        {
            var msg = !string.IsNullOrEmpty(ex.Message) ? ex.Message : "Tamanho da entrada inválido!";
            throw new Exception(msg);
        }
    }

    private static char ValidarDirecao(char direcao)
    {
        return direcao switch
        {
            'N' => char.Parse(DirecaoType.Norte),
            'S' => char.Parse(DirecaoType.Sul),
            'E' => char.Parse(DirecaoType.Leste),
            'W' => char.Parse(DirecaoType.Oeste),
            _ => throw new Exception("Direção inválida!")
        };
    }
}