int [] direccion =  {5, 20, 5, 9, 7};
double sumadecuadrados =  0;
double magnitud;

for (int i = 0; i < direccion.Length; i++)
{
    sumadecuadrados += Math.Pow (direccion[i], 2);
}

magnitud = Math.Sqrt(sumadecuadrados);
Console.WriteLine($"La magnitud del vector es {magnitud} ");

