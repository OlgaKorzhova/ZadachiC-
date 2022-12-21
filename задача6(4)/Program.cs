// Из трех чисел наибольшее

Console.Clear();
Console.Write("Введите первое число" );
int firstn = int.Parse(Console.ReadLine());
Console.Write("Введите второе число" );
int secondn = int.Parse(Console.ReadLine());
Console.Write("Введите третье число" );
int threen = int.Parse(Console.ReadLine());

if((firstn > secondn) && (firstn > threen))
{
    Console.Write(firstn);
}
if((secondn > firstn) && (secondn > threen))
{
    Console.Write(secondn);
}
if((threen > firstn) && (threen > secondn))
{
    Console.Write(threen);
}
