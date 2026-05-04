Console.WriteLine("Hello, World!");
int nota, suma=0, promedio=0;

Console.WriteLine("Cuantas notas vas a evaluar?");
int numdenota= int.Parse(Console.ReadLine()!);
for (int i = 1; i <= numdenota; i++)
{
    Console.WriteLine($"Nota # {i}: ");
    nota = int.Parse(Console.ReadLine()!);
    suma += nota;
}
promedio = suma / numdenota;
Console.WriteLine($"El promedio es {promedio}");
