/* Программа, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Enter a three-digit number (Введите трехзначное число)");
int num = Convert.ToInt32(Console.ReadLine());
int EnterSecondNumber(int num)
{
    int count;
    count = num % 100 / 10;
    return count;
}
int SecondNumber = EnterSecondNumber(num);
Console.WriteLine($"The second digit of {num} this number {SecondNumber}(вторая цифра этого числа {SecondNumber}) ");