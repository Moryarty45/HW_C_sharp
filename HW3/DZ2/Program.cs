Console.WriteLine ("Введите координату Х первой точки: ");
double x1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату Y первой точки: ");
double y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату Z первой точки: ");
double z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату X второй точки: ");
double x2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату Y второй точки: ");
double y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine ("Введите координату Z второй точки: ");
double z2 = int.Parse(Console.ReadLine()!);

double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

Console.WriteLine(d);