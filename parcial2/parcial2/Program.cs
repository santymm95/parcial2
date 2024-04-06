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



    }
}
