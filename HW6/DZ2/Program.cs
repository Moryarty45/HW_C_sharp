System.Console.WriteLine("Введите координаты первой прямой A и B через запятую:");
double[] firstСoordinatesArray = ReadAndConvertStringToIntArray();
System.Console.WriteLine("Введите координаты второй прямой A и B через запятую:");
double[] secondCoorditatesArray = ReadAndConvertStringToIntArray();

double[] ReadAndConvertStringToIntArray()
{
    return System.Console.ReadLine()!
        .Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries)
        .Select(Double.Parse).ToArray();
} 

void IntersectionPointTwoLine(double[] firstArray, double[] secondArray)
{   
    double x = (firstArray[0] - secondArray[0]) / (secondArray[1] - firstArray[1]);
    double y = firstArray[1] * x + firstArray[0];
    System.Console.WriteLine($"Точка пересечения двух прямых: {x};{y}"); 
    return;
}

IntersectionPointTwoLine(firstСoordinatesArray, secondCoorditatesArray);