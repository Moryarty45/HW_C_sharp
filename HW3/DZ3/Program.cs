Console.WriteLine ("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i * i},");
}
Console.WriteLine("\b \b");