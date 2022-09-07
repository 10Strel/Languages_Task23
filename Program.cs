/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.WriteLine("Введите N:");

bool res = int.TryParse(Console.ReadLine(), out int n);

if (!res)
{
    Console.WriteLine("Ошибка ввода.\r\nВыполнение программы будет остановлено.");
    return;
}

for (int i = 1; i <= n; i++)
{
    double tmp = Math.Pow(i, 3);
    Console.Write($"{(i == 1 ? n + " -> " + tmp : ", " + tmp)}");
}

