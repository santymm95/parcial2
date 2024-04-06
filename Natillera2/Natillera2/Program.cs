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


        }
     
}
