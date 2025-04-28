int num1 = 0;
int num2 = 0;
int num3 = 0;
int suma = 0;
double Promedio = 0;

Console.WriteLine("Ingresas el primer numero");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingresas el segundo numero");
num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Ingresas el tercer numero");
num3 = Convert.ToInt32(Console.ReadLine());

suma = num1 + num2 +  num3;
Promedio = (double)suma / 3;
Console.WriteLine("El promedio es: ");
Console.WriteLine(Promedio);