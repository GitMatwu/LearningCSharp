using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sistema de Facturación");

        Console.Write("Ingrese el precio del producto: ");
        double precio = double.Parse(Console.ReadLine());

        Console.Write("Ingrese la cantidad: ");
        int cantidad = int.Parse(Console.ReadLine());

        Console.WriteLine("Seleccione la forma de pago:");
        Console.WriteLine("1 - Efectivo");
        Console.WriteLine("2 - Crédito");
        Console.Write("Ingrese el código de forma de pago: ");
        int formaPago = int.Parse(Console.ReadLine());

        double subtotal = precio * cantidad;
        double descuento = 0;
        double recargo = 0;
        double total = 0;

        if (formaPago == 1) // Efectivo
        {
            if (subtotal > 100000)
            {
                descuento = subtotal * 0.10; // 10% de descuento
            }
            total = subtotal - descuento;
        }
        else if (formaPago == 2) // Crédito
        {
            recargo = subtotal * 0.30; // 30% de recargo
            total = subtotal + recargo;
        }
        else
        {
            Console.WriteLine("Forma de pago inválida.");
            return;
        }

        Console.WriteLine("\n--- Detalle de la operación ---");
        Console.WriteLine($"Subtotal: ${subtotal:F2}");
        Console.WriteLine($"Descuento aplicado: ${descuento:F2}");
        Console.WriteLine($"Recargo aplicado: ${recargo:F2}");
        Console.WriteLine($"Total a pagar: ${total:F2}");
    }
}