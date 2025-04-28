Double baC = 0;
Double Altura = 0;
Double area = 0;
Double perimetro = 0;

Console.WriteLine("ingresar la base del rectangulo");
baC = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingresar la altura del rectangulo");
Altura = Convert.ToDouble(Console.ReadLine());

area = baC * Altura;
perimetro = (baC * 2) + (Altura * 2);

Console.WriteLine("el area del rectangulo es: " + area);
Console.WriteLine("el perimetro del rectangulo es: " + perimetro);



