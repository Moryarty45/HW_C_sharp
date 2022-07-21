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

int[,] SortArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < 4; k++)
            {
                if (Array[i, j] < Array[i, k])
                {
                    int changeArray0 = Array[i, k];
                    int changeArray1 = Array[i, j];
                    Array[i, j] = changeArray0;
                    Array[i, k] = changeArray1;
                }

            }
        }
    }
    return Array;
}
int[,] result = CreateArray(3, 4);
PrintArray(result);
Console.WriteLine("-------------------------------");
int[,] resultSort = SortArray(result);
PrintArray(resultSort);