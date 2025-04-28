Double Ingles, Frances, Portuges;
Double porcentajeIngles, porcentajeFrances, porcentajePortuges;

Console.WriteLine("Ingrese la cantidad de alumnos en Ingles:");
Ingles = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de alumnos en Frances:");
Frances = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de alumnos en Portugues:");
Portuges = Convert.ToDouble(Console.ReadLine());

Double totalAlumnos = Ingles + Frances + Portuges;

porcentajeIngles = (Ingles / totalAlumnos) * 100;
Console.WriteLine("El porcentaje de alumnos en Ingles es: " + porcentajeIngles + "%");

porcentajeFrances = (Frances / totalAlumnos) * 100;
Console.WriteLine("El porcentaje de alumnos en Frances es: " + porcentajeFrances + "%");

porcentajePortuges = (Portuges / totalAlumnos) * 100;
Console.WriteLine("El porcentaje de alumnos en Portugues es: " + porcentajePortuges + "%");
