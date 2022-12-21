// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка)

Console.Clear();
Console.Write("Введите число" );
int first = int.Parse(Console.ReadLine());

if(first % 2 == 0)
{
    Console.Write("Четное");
}
else
{
    Console.Write("Нечетное");
}