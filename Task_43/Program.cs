//  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void CrossPoint(double a1, double a2, double c1, double c2, out double x, out double y)
{
    x = (c2 - c1) / (a1 - a2);
    y = a1 * x + c1;
}

double b1 = GetNumber("Введите коэффициент B1: ");
double k1 = GetNumber("Введите коэффициент K1: ");
double b2 = GetNumber("Введите коэффициент B2: ");
double k2 = GetNumber("Введите коэффициент K2: ");


if (k1 == k2 && b1 != b2)
    System.Console.WriteLine("Прямые параллельны");

else if (k1 == k2 && b1 == b2)
    System.Console.WriteLine("Прямые совпадают");

else if (k1 == 0 && b1 == 0)
    System.Console.WriteLine("Первая прямая не существует");

else if (k2 == 0 && b2 == 0)
    System.Console.WriteLine("Вторая прямая не существует");
else
{
    CrossPoint(k1, k2, b1, b2, out double x, out double y);
    System.Console.WriteLine($"Две прямые заданные уравнениями y = k1*x + b1, y = k2*x + b2 с заданными коэффициентами пересекаются в точке ({x}; {y})");
}