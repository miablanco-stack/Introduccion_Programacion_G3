

using System;

int numero = 0;
string dia= "";
Console.WriteLine("Dime un numero del 1 al 7");
try
{
    numero = int.Parse(Console.ReadLine()!);
}
catch (Exception ex)
{
    Console.WriteLine("Error:" + ex.Message);
}

switch (numero)

{
    case 1:
    dia = "Lunes";
    break;
    case 2:
    dia = "Martes";
    break;
    case 3:
    dia = "Miercoles";
    break;
    case 4:
    dia = "jueves";
    break;
    case 5:
    dia = "viernes";
    break;
    case 6:
    dia = "Sabado";
    break;
    case 7:
    dia = "Domingo";
    break;
    default:
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Escriba un numero entre 1 y 7");
    Console.ResetColor();
    break;

}
if (numero != 0) Console.WriteLine($"El dia seleccionado es {dia}. ");