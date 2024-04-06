using System;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            double ahorroTotal1 = 0, ahorroTotal2 = 0, multasTotal = 0, interesesTotal = 0;
            double prestamo1 = 0, prestamo2 = 0;

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.WriteLine($"\n--- Mes {mes} ---");

                double aporte1, aporte2;
                ahorroTotal1 += RegistrarAporte(1, mes, out aporte1, out prestamo1);
                ahorroTotal2 += RegistrarAporte(2, mes, out aporte2, out prestamo2);

                if (aporte1 == 0)
                    multasTotal += 20000;
                if (aporte2 == 0)
                    multasTotal += 20000;

                interesesTotal += CalcularIntereses(prestamo1, mes);
                interesesTotal += CalcularIntereses(prestamo2, mes);
            }

            Console.WriteLine("\n\n--- Liquidación anual ---");
            LiquidarAnualmente(ahorroTotal1, ahorroTotal2, multasTotal, interesesTotal, prestamo1, prestamo2);

            Console.Write("\n¿Desea continuar con otro año? (s/n): ");
            continuar = Console.ReadLine().ToLower() == "s";
        }

        Console.WriteLine("\n¡Gracias por utilizar la Cooperativa Navideña!");
    }

    static double RegistrarAporte(int numMiembro, int mes, out double aporte, out double prestamo)
    {
        Console.WriteLine($"\nIngrese los datos para el miembro {numMiembro}, mes {mes}:");
        Console.Write("Cantidad aportada: $");
        aporte = double.Parse(Console.ReadLine());

        Console.Write("¿Desea solicitar un préstamo? (s/n): ");
        if (Console.ReadLine().ToLower() == "s")
        {
            Console.Write("Cantidad del préstamo: $");
            prestamo = double.Parse(Console.ReadLine());
        }
        else
        {
            prestamo = 0;
        }

        return aporte;
    }

    static double CalcularIntereses(double prestamo, int mes)
    {
        if (prestamo <= 0)
            return 0;

        double tasaInteresMensual = 0.025; // 2.5% mensual
        return prestamo * tasaInteresMensual * (12 - mes); // Interés acumulado desde el mes siguiente al préstamo hasta diciembre
    }

    static void LiquidarAnualmente(double ahorroTotal1, double ahorroTotal2, double multasTotal, double interesesTotal, double prestamo1, double prestamo2)
    {
        double totalNeto1 = ahorroTotal1 - prestamo1 + interesesTotal - multasTotal;
        double totalNeto2 = ahorroTotal2 - prestamo2 + interesesTotal - multasTotal;

        Console.WriteLine($"Ahorro total del miembro 1: ${ahorroTotal1}");
        Console.WriteLine($"Ahorro total del miembro 2: ${ahorroTotal2}");
        Console.WriteLine($"Total de multas pagadas: ${multasTotal}");
        Console.WriteLine($"Total de intereses generados: ${interesesTotal}");
        Console.WriteLine($"Total neto a liquidar al miembro 1: ${totalNeto1}");
        Console.WriteLine($"Total neto a liquidar al miembro 2: ${totalNeto2}");
    }
}
