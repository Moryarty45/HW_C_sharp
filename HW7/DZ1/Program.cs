double [,] CreateArray(int x, int y)
{
    double [,] Array = new double [x, y];
    var random = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = Math.Round(random.NextDouble()*100,1);
        }
    }
    return Array;
}

void PrintArray(double [,] Array)
{
   
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}"+"\t");
        }
        Console.WriteLine();
    }
}

PrintArray (CreateArray(3, 4));