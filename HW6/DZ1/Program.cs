System.Console.WriteLine("Введите несколько цифр через запятую:");

int[] numbersArray = ReadAndConvertStringToIntArray();
int[] ReadAndConvertStringToIntArray()
{
    return System.Console.ReadLine()!
        .Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries)
        .Select(Int32.Parse).ToArray();
} 

int countGreaterZero = 0;
foreach (var numbers in numbersArray)
{
    if(numbers > 0)
    {
        countGreaterZero++;
    }
}

System.Console.Write($"Введено чисел больше ноля: {countGreaterZero}");