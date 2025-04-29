using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Conversor de Pesos a otras monedas");

        Console.Write("Ingrese la cantidad de pesos: ");
        
        double pesos = double.Parse(Console.ReadLine());
        double tasaDolar = 1200;  
        double tasaEuro = 1300;  
        double tasaReal = 200;   

        double dolares = pesos / tasaDolar;
        double euros = pesos / tasaEuro;
        double reales = pesos / tasaReal;

        Console.WriteLine($"\nEquivalencias:");
        Console.WriteLine($"Dólares: {dolares:F2} USD");
        Console.WriteLine($"Euros: {euros:F2} EUR");
        Console.WriteLine($"Reales: {reales:F2} BRL");
    }
}