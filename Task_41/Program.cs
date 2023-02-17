//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int CountLessThanZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

metka:
System.Console.WriteLine("Введите несколько чисел: ");
int[] myArray = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
if (myArray.Length == 1)
{
    System.Console.WriteLine("Вы ввели одно число!");
    goto metka;
}

Console.WriteLine($"Среди введённых чисел {CountLessThanZero(myArray)} больше нуля");