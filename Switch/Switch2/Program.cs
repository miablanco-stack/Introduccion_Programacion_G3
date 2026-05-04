// 

double numero1 = 0;
double numero2 = 0;
double calculo = 0;
string opcion = "";
Console.Write("Introduzca dos numeros: ");
try
{
    numero1 = double.Parse(Console.ReadLine()!);
    numero2 = double.Parse(Console.ReadLine()!);

}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

Console.WriteLine("Menu\n + Suma \n - Resta \n * Multplicacion \n / Division");
Console.WriteLine("Elije una opcion del menu: ");
try
{
    opcion = Console.ReadLine();
}
catch(Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

switch(opcion)
{
    case "+":
        calculo = numero1 + numero2;
        break;
    case "-":
        calculo = numero1 - numero2;
        break;
    case "*":
        calculo = numero1 * numero2;
        break;
    case "/":
        calculo = numero1 / numero2;
        break;
    default:
        Console.WriteLine("Opcion invalida");
        break;
}


Console.WriteLine($"{numero1} {opcion} {numero2} = {calculo}");


