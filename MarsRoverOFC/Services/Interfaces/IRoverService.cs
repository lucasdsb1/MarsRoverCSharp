using MarsRoverOFC.Models;

namespace MarsRoverOFC.Services.Interfaces;

public interface IRoverService
{
    public Rover ExecutarMovimentos(Rover rover);
}