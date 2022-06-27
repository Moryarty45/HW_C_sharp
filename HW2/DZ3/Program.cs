Console.WriteLine("Введи число дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if(x < 6)
{
    System.Console.WriteLine("Это не выходной день");
}
else
{
    System.Console.WriteLine("Это выходной день");
}