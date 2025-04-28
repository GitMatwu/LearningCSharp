Double Subtotal = 0, Total = 0;
Double Porcentaje = 0, Descuento = 0;

Console.WriteLine(&quot; Ingresar Importe de la venta &quot;);
Subtotal = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(&quot; Ingresar porcentaje de descuento &quot;);
Porcentaje = Convert.ToDouble(Console.ReadLine());

Descuento = Subtotal * Porcentaje / 100;

Total = Subtotal - Descuento;

Console.WriteLine(&quot; Subtotal & quot; +Subtotal.ToString());
Console.WriteLine(&quot; Descuento & quot; +Descuento.ToString());
Console.WriteLine(&quot; Total a pagar &quot; +Total.ToString());