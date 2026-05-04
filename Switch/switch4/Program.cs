Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;
Console.WriteLine("Bienvenido a la Universidad Americana ");
Console.WriteLine("Seleccione su carrera mediante el numero correspondiente");
Console.ResetColor();
Console.WriteLine("1.\t Ingeneria en Sistemas");
Console.WriteLine("2.\t Administracion de Empresas");
Console.WriteLine("3.\t Medicina");
int Opcion=0;

try
{
    Opcion = int.Parse(Console.ReadLine()!);
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
switch (Opcion)
{
    case 1: 
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("Tienes -100% de descuento en tu carrera");
    Console.ResetColor();
    break;
    case 2:
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("Tienes -80% de descuento en tu carrera");
    Console.ResetColor();
    break;
    case 3:
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("Tienes -50% de descuento en tu carrera");
    Console.ResetColor();
    break;
    default:
    Console.WriteLine("Opcion no Valida");
    break;
}