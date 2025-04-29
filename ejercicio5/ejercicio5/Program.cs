using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de compra con descuento");

        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad a comprar: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el porcentaje de descuento: ");
        double porcentajeDescuento = double.Parse(Console.ReadLine());

        double subtotal = precio * cantidad;
        double descuento = subtotal * (porcentajeDescuento / 100);
        double total = subtotal - descuento;

        Console.WriteLine($"\nSubtotal: ${subtotal:F2}");
        Console.WriteLine($"Descuento aplicado: ${descuento:F2}");
        Console.WriteLine($"Total a pagar: ${total:F2}");
    }
}