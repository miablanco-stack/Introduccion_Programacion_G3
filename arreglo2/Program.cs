/* Crear un arreglo de notas de 15 estudiantes, 
luego calcula el promedio de las notas y los tres primeros lugares,
no se puede ingresar notas menores a cero o mayor a 100*/
int[] notas = new int[15];
int suma = 0, contError = 0;
double promedio = 0;
for (int i = 0; i < notas.Length; i++)
{
    if (contError >= 3)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Se han alcanzado el número máximo de intentos fallidos. El programa se cerrará.");
        Console.ResetColor();
    }
    {
        Console.WriteLine($"Intento fallido: {contError}");
    }
    try
    {
        Console.WriteLine($"Ingrese la nota del estudiante {i + 1}: ");
        int nota = int.Parse(Console.ReadLine());
        if (nota < 0 || nota > 100)
        {
            throw new ArgumentOutOfRangeException("La nota debe estar entre 0 y 100.");
        }
        notas[i] = nota;
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar la nota
        contError++; // Incrementar el contador de errores
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine(ex.Message);
        i--; // Decrementar el índice para volver a solicitar la nota
        contError++; // Incrementar el contador de errores
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ocurrió un error: {ex.Message}");
        i--; // Decrementar el índice para volver a solicitar la nota
        contError++; // Incrementar el contador de errores
    }
    
}
promedio = (double)suma / notas.Length;
Console.WriteLine($"El promedio de las notas es: {promedio}");

foreach(int nota in notas)
{
   suma += nota;
}
Console.WriteLine($"La suma de las notas es: {suma}");

promedio = suma / notas.Length;
Console.WriteLine($"El promedio de las notas es: {promedio}");

Array.Sort(notas);
Array.Reverse(notas);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Cuadro de honor:");

for (int i = 0; i < 3; i++)
{
    Console.WriteLine( notas[i]);
}