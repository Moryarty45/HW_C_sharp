void fillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 100);
        }
}

int[] array = new int[10];
fillArray(array);
int result = 0;

for (int i = 1; i < array.Length; i+=2)
{
    result += array[i];
}
System.Console.WriteLine($"Массив:[{String.Join(";", array)}]");
System.Console.WriteLine($"Сумма эллементов на нечётных позициях: {result}");