Console.WriteLine($"Введите число,определяющее количество рандомных чисел: ");
int number = int.Parse(Console.ReadLine()!);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 1000);
        }
    return array;
}

void CountEvensNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count += 1;
        }
    Console.WriteLine($"Количество четных чисел в массиве {count}");
}

int[] newArray = CreateArray(number);
Console.WriteLine($"Массив:[{String.Join(";", newArray)}]");

CountEvensNumbers(newArray);