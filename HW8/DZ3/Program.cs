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

int[,] MultiplicArray(int[,] FirstArray, int[,] SecondArray)
{
    int[,] MultiArray = new int[3,4];

    for (int i = 0; i < FirstArray.GetLength(0); i++)
    {
        for (int j = 0; j < FirstArray.GetLength(1); j++)
        {
            for (int k = 0; k < FirstArray.GetLength(0); k++)
            {
                MultiArray[i, j] += FirstArray[i, k] * SecondArray[k, j];
            }
        }
    }
    return MultiArray;
}

int[,] resultFirstArray = CreateArray(3, 4);
PrintArray(resultFirstArray);
Console.WriteLine();
int[,] resultSecondArray = CreateArray(3, 4);
PrintArray(resultSecondArray);
Console.WriteLine();
PrintArray(MultiplicArray(resultFirstArray, resultSecondArray));