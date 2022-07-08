Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

int[] CreateArray(int a)
{
    for (int i = 0; i < a; i++)
    {
        Console.WriteLine($"Введите элемент массива № {i + 1}");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void ShowArray()
{
Console.Write("Массив: ");
for (int i = 0; i < size; i++)
{
    Console.Write($"{array[i]},");
}
}

CreateArray(size);
ShowArray();

System.Console.WriteLine("\b \b");