System.Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int FuncAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return FuncAkkerman(m - 1, 1);
    else if (m > 0 && n > 0) return (FuncAkkerman((m - 1), FuncAkkerman(m,( n - 1))));
    else return 0;
}

System.Console.WriteLine($"Функция Аккермана от ({m}, {n}) = {FuncAkkerman(m, n)}");