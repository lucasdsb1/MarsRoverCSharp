using MarsRoverOFC.Models;
using MarsRoverOFC.Services;
using MarsRoverOFC.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddSingleton<IPlatorService, PlatorService>();
services.AddSingleton<IMovimentoService, MovimentoService>();
services.AddSingleton<IPosicaoService, PosicaoService>();
services.AddSingleton<IRoverService, RoverService>();
var serviceProvider = services.BuildServiceProvider(true);

try
{
    var platorService = serviceProvider.GetService<IPlatorService>();
    var movimentoService = serviceProvider.GetService<IMovimentoService>();
    var posicaoService = serviceProvider.GetService<IPosicaoService>();
    var roverService = serviceProvider.GetService<IRoverService>();

    Console.WriteLine("Coordenadas: (Formato aceito: 5 5)");
    var plator = platorService?.ConverterParaPlator(Console.ReadLine() ?? string.Empty);

    Console.WriteLine("\nPosição inicial do Rover: (Formato aceito: 1 2 N)");
    var posicao = posicaoService?.ConverterParaPosicao(Console.ReadLine() ?? string.Empty, plator ?? throw new Exception("Plator não pode ser nulo!"));

    Console.WriteLine("\nMovimentos: (Formato aceito: LMLMLMLMRM)");    
    var movimentos = movimentoService?.ConverterParaMovimento(Console.ReadLine() ?? string.Empty);

    var rover = new Rover(
        plator ?? throw new Exception("Plator não pode ser nulo!"), 
        posicao ?? throw new Exception("Posicao não pode ser nulo!"), 
        movimentos ?? throw new Exception("Movimentos não pode ser nulo!"));
    rover = roverService?.ExecutarMovimentos(rover);

    Console.WriteLine($"\n{rover.Posicao.X} {rover.Posicao.Y} {rover.Posicao.Direcao}");
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadKey();
}