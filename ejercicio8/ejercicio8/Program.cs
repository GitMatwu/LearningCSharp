using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Cálculo de salario mensual con detalle de horas extras");

        Console.Write("Ingrese la cantidad de horas trabajadas en el mes: ");
        int horasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de la hora: ");
        double valorHora = double.Parse(Console.ReadLine());

        double salario = 0;
        int horasNormales = 0;
        int horasExtras = 0;
        double pagoHorasNormales = 0;
        double pagoHorasExtras = 0;

        if (horasTrabajadas <= 160)
        {
            horasNormales = horasTrabajadas;
            pagoHorasNormales = horasNormales * valorHora;
            salario = pagoHorasNormales;
        }
        else
        {
            horasNormales = 160;
            horasExtras = horasTrabajadas - 160;
            pagoHorasNormales = horasNormales * valorHora;
            pagoHorasExtras = horasExtras * valorHora * 2; // horas extras al doble
            salario = pagoHorasNormales + pagoHorasExtras;
        }

        Console.WriteLine("\nDetalle del salario:");
        Console.WriteLine($"Horas normales trabajadas: {horasNormales} horas");
        Console.WriteLine($"Pago por horas normales: ${pagoHorasNormales:F2}");
        Console.WriteLine($"Horas extras trabajadas: {horasExtras} horas");
        Console.WriteLine($"Pago por horas extras: ${pagoHorasExtras:F2}");
        Console.WriteLine($"Total a cobrar: ${salario:F2}");
    }
}