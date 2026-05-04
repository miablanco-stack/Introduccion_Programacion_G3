

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("--- ANALIZADOR DE NÚMEROS ---");
            Console.WriteLine("1. Analizar un número");
            Console.WriteLine("2. Salir");
            Console.Write("Seleccione una opción: ");
            
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese un número entero: ");
                    int numero = int.Parse(Console.ReadLine());

                    string signo = "";
                    string paridad = "";

                    if (numero > 0) signo = "Positivo";
                    else if (numero < 0) signo = "Negativo";
                    else signo = "Cero";

                   
                    if (numero % 2 == 0) paridad = "Par";
                    else paridad = "Impar";

                  
                    Console.WriteLine($"\nEl número {numero} es: {signo} y {paridad}.");
                    break;

                case "2":
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor, ingrese solo números enteros válidos.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
        }

        Console.WriteLine("\nPresione cualquier tecla para cerrar.");
        Console.ReadKey();
    }
}