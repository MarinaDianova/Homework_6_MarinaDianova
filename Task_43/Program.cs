//  Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToDouble(Console.ReadLine());
}

void CrossPoint(double a1, double a2, double c1, double c2, out double x, out double y)
{
    x = Math.Round((c2 - c1) / (a1 - a2), 2);
    y = Math.Round(a1 * x + c1, 2);
}

bool Validation(double a1, double a2, double c1, double c2)
{
if (a1 == a2 && c1 != c2)
    {System.Console.WriteLine("Прямые параллельны");
    return false;
    }

else if (a1 == a2 && c1 == c2)
    {System.Console.WriteLine("Прямые совпадают");
    return false;
    }

else if (a1 == 0 && c1 == 0)
    {System.Console.WriteLine("Первая прямая не существует");
    return false;
    }

else if (a2 == 0 && c2 == 0)
    {System.Console.WriteLine("Вторая прямая не существует");
    return false;
    }
return true;
}

double b1 = GetNumber("Введите коэффициент B1: ");
double k1 = GetNumber("Введите коэффициент K1: ");
double b2 = GetNumber("Введите коэффициент B2: ");
double k2 = GetNumber("Введите коэффициент K2: ");

System.Console.WriteLine();

if (Validation(b1, b2, k1, k2))
{
    CrossPoint(b1, b2, k1, k2, out double x, out double y);
    System.Console.WriteLine($"Две прямые, заданные уравнениями y = {k1}*x + {b1} и y = {k2}*x + {b2} пересекаются в точке ({x}; {y})");
}
System.Console.WriteLine();