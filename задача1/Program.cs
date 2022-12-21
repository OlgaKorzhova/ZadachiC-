// программа принимает на вход 2 числа и проверяет, является ли первое, квадратом второго

Console.Write("Введите первое число" );
int firstnumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число" );
int secondnumber = int.Parse(Console.ReadLine());

if(firstnumber == secondnumber * secondnumber)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}