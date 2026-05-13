int [] ventas = new int [7];
double total = 0;
int ventaSuperior = 0;
int min = int.MaxValue;

Console.WriteLine("Registro de ventas de la semana");

for (int i = 0; i < ventas.Length; i++)
{
    try
    {
        Console.WriteLine($"Cuanto es el total de las ventas del dia #{i + 1}");
        ventas[i] = int.Parse(Console.ReadLine());
        total += ventas[i];
       
        if (ventas[i] > 150)
        {
            ventaSuperior ++;
        }
       if (ventas[i] < min)
        {
            min = ventas [i];
        }
        /*if (ventas[i] < ventaMenor)
        {
            ventaMenor = ventas [i];
        }*/
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Digita un valor valido");
        Console.ResetColor();
        i--;
    }
}

Console.WriteLine($"El total vendido en esta semana es ${total}");
Console.WriteLine($"Las ventas superaron que superaron $150 fueron {ventaSuperior}");
Console.WriteLine($"La venta minima fue de {min}");
