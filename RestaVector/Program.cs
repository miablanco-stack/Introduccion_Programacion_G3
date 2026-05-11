int [] vector1 = new int [5];
int [] vector2 = new int [5];
int [] restaVector = new int [5];

Console.WriteLine("Ingresa los valores del primer vector");
for (int i = 0;  i < vector1.Length; i++)
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
        i--; //Decrementar el indice para volver a solicitar el valor
        Console.ResetColor();
    }
}
Console.WriteLine("Ingresa los valores del segundo vector");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Ingrese el Valor {i + 1}");
        vector2[i] = int.Parse(Console.ReadLine());
    
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Por favor ingrese un numero valido");
        i--; //Decrementar el indice para volver a solicitar el valor
        Console.ResetColor();
    }
}
//Restar Vectores
for (int i = 0; i < restaVector.Length; i++)
{
    restaVector[i] = vector1[i] - vector2[i];
}
// Mostrar arreglo resultante
for (int i = 0; i < restaVector.Length; i++)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"El rsultado de la diferencia entre el vector uno y el vector dos en la posicion {i + 1} es {restaVector[i]}");
}