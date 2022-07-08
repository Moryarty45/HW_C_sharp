Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int result = 1;
int Exp(int numA, int numB)
{
    for (int i = 1; i <= numB; i++)
        {
            result = result * numA;
        }
    return result;
}

Console.WriteLine(Exp(numberA,numberB));