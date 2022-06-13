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
                throw new Exception();
            }

            Plator plator;

            if (int.TryParse(coordenadas[0], out var x) && int.TryParse(coordenadas[1], out var y))
            {
                plator = new Plator(x, y);
            }
            else
            {
                throw new Exception();
            }

            if (plator.X < 0 || plator.Y < 0)
            {
                throw new Exception();
            }

            return plator;
        }
        catch (Exception)
        {
            throw new Exception("Não foi possível criar o Plator!");
        }
    }
}