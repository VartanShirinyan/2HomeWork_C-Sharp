/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Enter an integer number (Введите целое число) ");
int num = Convert.ToInt32(Console.ReadLine());
int j = 0;
if (num > 99)
{
    while (num >= 1000)
    {
        num /= 10;
    }
        if (num > 99 && num < 1000)
    {
        j = num % 10;
    }
    Console.WriteLine($"{j}");
}
else
{
    Console.WriteLine($"There is no third digit (Третьей цифры нет)");
}