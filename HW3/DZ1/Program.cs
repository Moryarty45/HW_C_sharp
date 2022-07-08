Console.WriteLine ("Введите пятизначное число: ");
string i = Console.ReadLine()!;

if (i [0] == i [4] && i [1] == i [3])
{
    Console.WriteLine("Палиндром");
} else
{
    Console.WriteLine("Не палиндром");
}