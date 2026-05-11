
Console.Clear();
int [] temperatura = new int [7];
double suma = 0;
int max = int.MinValue;
int min = int.MaxValue;
Console.WriteLine("A continuacion dime las siguientes temperaturas de la semana");

for(int i = 0; i < temperatura.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese la temperatura #{i + 1}");
        temperatura[i] = int.Parse(Console.ReadLine()!);
        suma += temperatura [i];
        if (temperatura[i] > max)
        {
            max = temperatura[i];
        }

        if (temperatura[i] < min)
        {
            min = temperatura[i];
        }
    
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingresa un valor valido");
        Console.ResetColor();
        i--; //Decrementar para poner un valor valido en ese espacio
    }
}

Console.WriteLine("Los datos de las 7 temperaturas son los siguientes:");
for(int i = 0; i < temperatura.Length; i++)
{
    Console.WriteLine($"La temperatura # {i + 1} tiene el valor de {temperatura[i]}");
}
double promedio = suma / 7;
Console.WriteLine($"El promedio de temperatura de la semana es {Math.Round(promedio,2)}");
Console.WriteLine($"La temperatura mas alta es {max} y la temperatura mas baja es {min}");
