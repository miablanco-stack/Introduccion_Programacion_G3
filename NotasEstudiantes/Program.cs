int [] nota = new int [8];
int aprobado = 0;
int reprobado = 0;
double suma = 0;
double promedio;

for (int i = 0; i < nota.Length; i++)
{
    try
    {
        Console.WriteLine($"Dime la nota del estudiante #{i + 1}");
        nota[i] = int.Parse(Console.ReadLine());

        suma += nota[i];

        if (nota[i] > 70)
        {
            aprobado++;
        }
        
        else if(nota[i] < 70)
        {
            reprobado++;
        }
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Digita un valor valido");
        Console.ResetColor();
        i--;
    }
}

Array.Sort(nota);
Array.Reverse(nota);
Console.WriteLine("Las notas de los estudiantes aprobados son:");
foreach (int n in nota)
{
    if (n > 70)
    {
        Console.WriteLine($"Nota: {n}");
    }
}
Console.WriteLine($"{reprobado} estudiantes fueron reprobados");

promedio = Math.Round((double)suma / 8, 2);
Console.WriteLine($"El promedio general del grupo es {promedio}");


