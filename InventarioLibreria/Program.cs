int [] categoria = new int [5];
int total = 0;
int max = int.MinValue;
double promedio;
for (int i = 0; i < categoria.Length; i++)
{
    try
    {
        Console.WriteLine($"Cuantos libros se vendieron en la categoria #{i + 1}");
        categoria[i] = int.Parse(Console.ReadLine());
        total += categoria[i];

        if (categoria[i] > max)
        {
            max = categoria[i];
        }
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Digite el formato correcto");
        Console.ResetColor();
        i--;
    }
}

promedio =Math.Round((double) total / 5, 2);
Console.WriteLine($"El total de libros vendidos es {total}");
Console.WriteLine($"La categoria con mas ventas fue {max}");
Console.WriteLine($"El promedio de libros vendidos en estas 5 categorias es de {promedio}");