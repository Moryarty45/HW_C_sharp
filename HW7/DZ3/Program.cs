int[,] CreateArray(int x, int y)
{
    int[,] Array = new int[x, y];
    var random = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = random.Next(0, 10);
        }
    }
    return Array;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}");
        }
        Console.WriteLine();
    }
}

void MeanValue(int[,] Array)
{
    double sumValue = 0;
    double meanValue = 0;
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        sumValue = 0;
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            sumValue += Array[i, j];
        }
        meanValue = sumValue / Array.GetLength(0);
        Console.WriteLine($"Среднее значение столбца = {Math.Round(meanValue, 2)}");
    }

}
int[,] result = CreateArray(3, 4);
PrintArray(result);
MeanValue(result);