using System;

class Program
{
    static void Main()
    {
        string usuarioCorrecto = "user";
        string contraseñaCorrecta = "1234";
        double saldo = 500000;

        Console.Write("Ingrese el nombre de usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Ingrese la contraseña: ");
        string contraseña = Console.ReadLine();

        if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
        {
            Console.WriteLine("Bienvenido al sistema.\n");

            Console.WriteLine("Saldo actual: $" + saldo);
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Depósito");
            Console.WriteLine("2 - Transferencia");

            Console.Write("Opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.Write("Ingrese el monto a depositar: $");
                double deposito = Convert.ToDouble(Console.ReadLine());
                saldo += deposito;
                Console.WriteLine($"Depósito realizado: ${deposito}");
                Console.WriteLine($"Saldo actual: ${saldo}");
            }
            else if (opcion == "2")
            {
                Console.Write("Ingrese el monto a transferir: $");
                double transferencia = Convert.ToDouble(Console.ReadLine());

                if (transferencia <= saldo)
                {
                    saldo -= transferencia;
                    Console.WriteLine($"Transferencia realizada: ${transferencia}");
                    Console.WriteLine($"Saldo actual: ${saldo}");
                }
                else
                {
                    Console.WriteLine("Fondos insuficientes para realizar la transferencia.");
                }
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
        else
        {
            Console.WriteLine("Usuario o contraseña incorrectos.");
        }
    }
}
