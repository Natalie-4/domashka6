/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */

Console.WriteLine("Введите общее количество чисел M = ");
int M = Convert.ToInt32(Console.ReadLine());
int [] Array = new int [M];

Console.WriteLine("Введите сами числа: ");

for (int i = 0; i < M; i++)
{
    Console.WriteLine("Введите число: ");
    Array[i]= Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine();

int positive = 0;

for (int i = 0; i < M; i++)
{
    Console.Write($"{Array[i]} ");
    Console.WriteLine();

    if (Array[i] > 0)
    {
        positive++;
    }
}

Console.WriteLine();
Console.WriteLine("Всего было " + positive + " положительных значений");

