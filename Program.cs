// Программа, которая на вход принимает исло и выдает ее квадрат

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sq = number * number;

Console.WriteLine($"Квадрат числа {number} равен {sq}");

