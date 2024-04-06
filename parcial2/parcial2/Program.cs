using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        Console.WriteLine("¡Bienvenido al juego Adivina el número!");
        Console.Write("Ingrese el número de jugadores (entre 2 y 4): ");
        int numJugadores;
        while (!int.TryParse(Console.ReadLine(), out numJugadores) || numJugadores < 2 || numJugadores > 4)
        {
            Console.WriteLine("Por favor ingrese un número válido de jugadores (entre 2 y 4): ");
        }
        int rangoMaximo;
        switch (numJugadores)
        {
            case 2:
                rangoMaximo = 50;
                break;
            case 3:
                rangoMaximo = 100;
                break;
            case 4:
                rangoMaximo = 200;
                break;
            default:
                rangoMaximo = 100;
                break;
        }
        int numeroAdivinar = random.Next(0, rangoMaximo);
        bool ganador = false;

        Console.WriteLine($"Se ha generado un número entre 0 y {rangoMaximo - 1}. ¡Adivina cuál es!");



    }
}
