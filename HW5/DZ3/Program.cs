double[] array = new double[20];
void fillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    System.Console.WriteLine($"Массив:[{String.Join(";", array)}]");
}

void findMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        else if (min > array[i]) min = array[i];

    }
    System.Console.WriteLine($"Разница между max ({max}) и min ({min}) = {max - min}");
}

fillArray(array);
findMaxMin(array);