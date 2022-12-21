// Программа на вход принимает 1 число и на выходе показывает все целые числа в промежутке от - N до N

Console.Write("Введите число" );
int numbern = int.Parse(Console.ReadLine());
int numberc = - numbern;

while(numberc <= numbern)
{
    Console.Write(numberc+" ");
numberc = numberc + 1;
}
