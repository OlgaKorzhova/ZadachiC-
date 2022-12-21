// Программа принимает на вход трехзначное число, а на выходе показывает последнюю цифру

Console.Write("Введите число" );
int number = int.Parse(Console.ReadLine());
if(number < 0)
{number = number * (-1);}
Console.WriteLine(number%10);