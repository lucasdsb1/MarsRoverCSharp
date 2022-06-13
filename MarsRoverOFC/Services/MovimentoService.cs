using MarsRoverOFC.Models;
using MarsRoverOFC.Services.Interfaces;
using MarsRoverOFC.Types;

namespace MarsRoverOFC.Services;

public class MovimentoService : IMovimentoService
{
    public List<char> ConverterParaMovimento(string movimentos)
    {
        try
        {
            movimentos = movimentos.ToUpper();
            return movimentos.Select(ValidarMovimento).ToList();
        }
        catch (Exception ex)
        {
            var msg = !string.IsNullOrEmpty(ex.Message) ? ex.Message : "Tamanho da entrada inválido!";
            throw new Exception(msg);
        }
    }

    private static char ValidarMovimento(char movimento)
    {
        return movimento switch
        {
            'L' => char.Parse(MovimentoType.Esquerda),
            'R' => char.Parse(MovimentoType.Direita),
            'M' => char.Parse(MovimentoType.Frente),
            _ => throw new Exception("Movimento(s) inválido(s)!")
        };
    }
}