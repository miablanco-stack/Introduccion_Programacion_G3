

using System.Numerics;

int [] vector1 = new int [5];
int [] vector2 = new int [5];
double producto = 0;
int [] vectorSuma = new int [5];

Console.WriteLine("Ingrese los elementos del primer vector:");
for (int i = 0; i < vector1.Length; i++)
{
    try
    {
         Console.WriteLine($"Ingrese el elemento de la posision {i + 1}");
         vector1[i] = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingrese un valor valido");
        Console.ResetColor();
        i --; 
    }

}
Console.WriteLine("Ingrese los elementos del segundo vector:");
for (int i = 0; i < vector2.Length; i++)
{
    try
    {
         Console.WriteLine($"Ingrese el elemento de la posision {i + 1}");
         vector2[i] = int.Parse(Console.ReadLine());
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingrese un valor valido");
        Console.ResetColor();
        i --; 
    }

}
for (int i = 0; i < vectorSuma.Length; i++)
{
    vectorSuma[i] = vector1[i]  * vector2[i];
    producto += vectorSuma[i];
}
Console.WriteLine($"El producto escalar total es {producto}");