/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Enter the day of the week (Введите день недели): ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
            Console.WriteLine("working day");
            break;
    case 2:
            Console.WriteLine("working day");
            break;
    case 3:
            Console.WriteLine("working day");
            break;
    case 4:
            Console.WriteLine("working day");
            break;
    case 5:
            Console.WriteLine("working day");
            break;    
    case 6:
            Console.WriteLine("Weekend");
            break;           
    case 7:
            Console.WriteLine("Weekend");
            break;
    default:
            Console.WriteLine("Not found");
            break;
}