int[,,] CreateArray(int x, int y, int z)
{
    int[,,] Array = new int[x, y, z];
    var random = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Array[i, j, k] = random.Next(1, 10);
            }
        }
    }
    return Array;
}

void PrintArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i, j, k],3} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

int[,,] result = CreateArray(2, 2, 2);
PrintArray(result);