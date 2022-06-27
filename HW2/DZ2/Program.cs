Console.WriteLine("Введите число: ");
string i = Console.ReadLine();
if (int.Parse (i) > 99)
{ 
    Console.WriteLine("Третья цыфра - " + i[2]); 
}
else
{
    Console.WriteLine("Третьей цифры нет");
}