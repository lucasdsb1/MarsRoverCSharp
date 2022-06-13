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
    var roverList = new List<Rover>();
    
    Console.WriteLine("Coordenadas: (Formato aceito: X:int Y:int. Ex.: 5 5)");
    var plator = platorService?.ConverterParaPlator(Console.ReadLine() ?? string.Empty);

    do
    {
        Console.WriteLine("\nPosição inicial do Rover: (Formato aceito: X:int Y:int A:char. Ex.: 1 2 N)");
        var posicao = posicaoService?.ConverterParaPosicao(Console.ReadLine() ?? string.Empty, plator ?? throw new Exception("Plator não pode ser nulo!"));

        Console.WriteLine("\nMovimentos: (Letras aceitas: L para LEFT | R para RIGHT | M para MOVE. Ex: LMLMLMLMM)");
        var movimentos = movimentoService?.ConverterParaMovimento(Console.ReadLine() ?? string.Empty);

        var rover = new Rover(
            plator ?? throw new Exception("Plator não pode ser nulo!"),
            posicao ?? throw new Exception("Posicao não pode ser nulo!"),
            movimentos ?? throw new Exception("Movimentos não pode ser nulo!"));

        roverList.Add(rover);        

        Console.WriteLine("\n---------------");
        Console.WriteLine("Deseja definir outro ROVER? (QUALQUER TECLA = SIM | N = NÃO)");
    } while (Console.ReadLine()?.ToUpper() != "N");

    foreach (var lastPosition in roverList.Select(rover => roverService?.ExecutarMovimentos(rover).Posicao))
    {
        Console.WriteLine($"\n{lastPosition?.X} {lastPosition?.Y} {lastPosition?.Direcao}");
    }

    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadKey();
}