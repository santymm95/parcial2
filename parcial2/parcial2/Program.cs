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

        while (!ganador)
        {
            for (int i = 1; i <= numJugadores; i++)
            {
                Console.Write($"Jugador {i}, ingresa tu número: ");
                int numeroIngresado;
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.WriteLine("Por favor ingresa un número válido: ");
                }

                if (numeroIngresado < numeroAdivinar)
                {
                    Console.WriteLine("¡MAYOR!");
                }
                else if (numeroIngresado > numeroAdivinar)
                {
                    Console.WriteLine("¡MENOR!");
                }
                else
                {
                    Console.WriteLine("¡HAS GANADO!");
                    ganador = true;
                    break;
                }
            }

            if (!ganador)
            {
                Console.WriteLine("Ningún jugador ha adivinado el número. ¿Desean seguir intentando? (s/n)");
                char continuar = Console.ReadKey().KeyChar;
                if (continuar != 's')
                    break;

                Console.Clear();
                Console.WriteLine($"Se ha generado un nuevo número entre 0 y {rangoMaximo - 1}. ¡Adivina cuál es!");
            }
        }


    }
}
