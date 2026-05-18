//Multiplicacion de matriz por escalar 
int k = 0;
int [,] Matriz = new int[3,3];

Console.WriteLine("Llenar matriz");
for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        
        Console.WriteLine($"Elemento {i} , {j}");
        Matriz[i,j] = int.Parse(Console.ReadLine());
       
    }

}

/*Mostrar matriz*/

Console.WriteLine("Matriz");
for(int f = 0; f < 3; f++)
{
    for(int c = 0; c < 3; c++)
    {
        Console.Write($" {Matriz [ f , c] } ");
    }
    Console.WriteLine();

}

// Multiplicar por el escalar
Console.Write("Dime el valor de escalar: ");
k = int.Parse(Console.ReadLine());
for (int i = 0; i < 3; i++)
{
    for(int j = 0; j < 3; j++)
    {
        Console.WriteLine($"Elemento {i} , {j}");
        Matriz[i,j] = Matriz[i,j] * k;
    }

}
Console.WriteLine("Matriz");
for(int f = 0; f < 3; f++)
{
    for(int c = 0; c < 3; c++)
    {
        Console.Write($" {Matriz [ f , c] } ");
    }
    Console.WriteLine();
}
