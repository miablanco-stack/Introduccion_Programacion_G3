
//pedir un numero y mostrar su tabla hasta el 12

Console.Write("Ingresa un numero del 1 al 12:  ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= 12; i++)
{
    Console.WriteLine($"{n} * {i} = {n*i}");
}

