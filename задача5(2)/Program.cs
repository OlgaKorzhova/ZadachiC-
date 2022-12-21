// Из двух чисел наибольшее

Console.Clear();
Console.Write("Введите первое число" );
int firstn = int.Parse(Console.ReadLine());
Console.Write("Введите второе число" );
int secondn = int.Parse(Console.ReadLine());

if(firstn > secondn)
{
    Console.Write(firstn);
}
else
{
    Console.Write(secondn);
}
