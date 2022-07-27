System.Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int SumNaturalElement(int m, int n)
{
    if (m == n) return n;
    else return (m + (SumNaturalElement(m + 1, n)));
}

System.Console.WriteLine($"Cумма натуральных элементов равняется {SumNaturalElement(m, n)}");