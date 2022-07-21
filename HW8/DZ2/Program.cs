int[,] CreateArray(int x, int y)
{
    int[,] Array = new int[x, y];
    var random = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = random.Next(1, 10);
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
            Console.Write($"{Array[i, j],3}" + "\t");
        }
        Console.WriteLine();
    }
}

double[] ArrayRowSum(int[,] array)
{
    double sum = 0;
    double[] SumRow = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        SumRow[j] = sum;
        sum = 0;
    }
    return SumRow;
}

void ArrayRowSumPrint(double[] Array)
{
    double min = double.MinValue;
    int n = 0;

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (min < Array[i])
        {
            min = Array[i];
            n = i;
        }
    }
    Console.WriteLine($"Строка №{n}");
}
int[,] result = CreateArray(3, 4);
PrintArray(result);
double [] sumRow = ArrayRowSum(result);
ArrayRowSumPrint(sumRow);