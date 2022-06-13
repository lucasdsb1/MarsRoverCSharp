using MarsRoverOFC.Models;
using MarsRoverOFC.Services.Interfaces;

namespace MarsRoverOFC.Services;

public class PlatorService : IPlatorService
{
    public Plator ConverterParaPlator(string inputCoordenadas)
    {
        try
        {
            var coordenadas = inputCoordenadas.Split(" ");

            if (coordenadas.Length != 2)
            {
                throw new Exception("Tamanho inválido");
            }

            Plator plator;

            if (int.TryParse(coordenadas[0], out var x) && int.TryParse(coordenadas[1], out var y))
            {
                plator = new Plator(x, y);
            }
            else
            {
                throw new Exception("Não foi possível converter a entrada para coordenadas!");
            }

            if (plator.X < 0 || plator.Y < 0)
            {
                throw new Exception("Números negativos não são aceitos!");
            }

            return plator;
        }
        catch (Exception ex)
        {
            var msg = !string.IsNullOrEmpty(ex.Message) ? ex.Message : "Tamanho da entrada inválido!";
            throw new Exception(msg);
        }
    }
}