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

string CheckArray(int[,] Array, int n, int m)
{
    if (n < Array.GetLength(0) && n < Array.GetLength(1)) return $"Значение элемента на позиции равна {Array[n, m]}";
    return "Такого элемента нет";

}

int[,] result = CreateArray(3, 4);
PrintArray(result);
Console.WriteLine(CheckArray(result, 1, 1));