Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
double k = k1 - k2;
double b = b2 - b1;
double x = b / k;
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;
if ((k1 == 0 || k2 == 0) || (k1 == 1 && k2 == 1))
{
    Console.Write($"Прямые не пересекаются");
}
else if(y1 == y2)
{
    Console.Write($"Прямые пересеаются по координате x = {x} и по координате y = {y1}");
}
else
{
    Console.Write($"Прямые не пересекаются");
}
