int[,] Matriz = new int [5 , 5];
int numeroBuscado;
bool primero= false;
int contadorEncuentros=0;

Console.WriteLine("Digite los elementos de la matriz 5x5");

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
       int numero;
        Console.WriteLine($"Matriz[{f},{c}]");
        while(!int.TryParse(Console.ReadLine(), out numero))
        {
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Inresa el formato correcto");
            Console.ResetColor();
            Console.WriteLine($"Matriz[{f},{c}]");
        }
        Matriz[f,c] = numero;
    }
}
Console.WriteLine("Que numero buscas?");
while(!int.TryParse(Console.ReadLine(), out numeroBuscado))
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Ingresa  el formato correcto ");
    Console.ResetColor();
    Console.WriteLine("Que numero buscas");
}

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    {
        if (Matriz[f, c] == numeroBuscado)
        {
            primero = true;
        }
       
    }
}
if (!primero)
{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine("Registro no encontrado");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Resultado de la matriz");

for (int f = 0; f < 5; f++)
{
    for (int c = 0; c < 5; c++)
    { 
        if (Matriz[f,c] == numeroBuscado)
            {
                contadorEncuentros ++;
                if(contadorEncuentros == 1)
                {
                    Console.ForegroundColor=ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                }
            }
     else
            {
                Console.ResetColor();
            }
            
            Console.Write( Matriz[f,c] + "\t");
    }
    Console.WriteLine();
}
}