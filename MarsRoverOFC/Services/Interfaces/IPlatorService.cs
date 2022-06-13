using MarsRoverOFC.Models;

namespace MarsRoverOFC.Services.Interfaces;

public interface IPlatorService
{
    public Plator ConverterParaPlator(string inputCoordenadas);
}