using System.Numerics;

int[] vector1 = new int[5];
int[] vector2 = new int[5];
int[] VectorSuma = new int[5];
Console.WriteLine("Por favor ingrese los valores del primer vector");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese el valor {i + 1}");
        vector1[i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un numero valido");
        i--; //Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }
}

Console.WriteLine("Por favor ingrese los valores del segundo vector");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.Write($"Valor {i + 1}:");
        vector2 [i] = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un numero valido");
        i--; //Decrementar el índice para volver a solicitar el valor
        Console.ResetColor();
    }
}

//Sumar vectores 
for (int i = 0; i < VectorSuma.Length; i++)
{
    VectorSuma[i] = vector1[i] + vector2[i];
}

//Mostrar arreglo resultante
for (int i = 0; i < VectorSuma.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"El resultado de la suma del vector 1 y el vector 2 en la posición {i + 1} es: {VectorSuma[i]}");
}