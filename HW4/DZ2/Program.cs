Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int SumNumber(int number)
{
    int counter = Convert.ToString(number).Length;
    int x = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        x = number - number % 10;
        result = result + (number - x);
        number = number / 10;
    }
    return result;
}

Console.WriteLine(SumNumber(number));