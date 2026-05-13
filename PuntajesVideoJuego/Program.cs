double[] puntaje = new double[6];
double max = double.MinValue;
double sobresaliente = 0 ;

for(int i = 0; i < puntaje.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingresa el puntaje # {i + 1}");
        puntaje[i] = double.Parse(Console.ReadLine());
        
        if (puntaje[i] > max)
        {
            max = puntaje [i];
        }
        if (puntaje[i] > 500)
        {
            sobresaliente ++;
        }

    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Digita en el formato correcto");
        Console.ResetColor();
        i --;
    }
}

Console.WriteLine($"El puntaje mas alto es {max}");
Array.Sort(puntaje);
Array.Reverse(puntaje);
Console.WriteLine("Estos son los puntajes de mayor a menor");

foreach(double i in puntaje)
{
    Console.WriteLine($" {i} ");
}
Console.WriteLine($"Hay {sobresaliente} puntajes mayor a 500");