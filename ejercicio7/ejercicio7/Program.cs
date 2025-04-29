using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de Áreas");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Triángulo");
        Console.WriteLine("3. Rectángulo");
        Console.Write("Ingrese el código de la figura: ");
        int codigo = int.Parse(Console.ReadLine());

        double area = 0;

        switch (codigo)
        {
            case 1:
                Console.Write("Ingrese el radio del círculo: ");
                double radio = double.Parse(Console.ReadLine());
                area = 3.14 * radio * radio;
                Console.WriteLine($"El área del círculo es: {area}");
                break;

            case 2:
                Console.Write("Ingrese la base del triángulo: ");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del triángulo: ");
                double alturaTriangulo = double.Parse(Console.ReadLine());
                area = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine($"El área del triángulo es: {area}");
                break;

            case 3:
                Console.Write("Ingrese la base del rectángulo: ");
                double baseRectangulo = double.Parse(Console.ReadLine());
                Console.Write("Ingrese la altura del rectángulo: ");
                double alturaRectangulo = double.Parse(Console.ReadLine());
                area = baseRectangulo * alturaRectangulo;
                Console.WriteLine($"El área del rectángulo es: {area}");
                break;

            default:
                Console.WriteLine("Código de figura no válido.");
                break;
        }
    }
}