using MarsRoverOFC.Models;

namespace MarsRoverOFC.Services.Interfaces;

public interface IPosicaoService
{
    public Posicao ConverterParaPosicao(string posicaoInicial, Plator plator);
}