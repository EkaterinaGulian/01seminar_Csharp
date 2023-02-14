Console.WriteLine("является ли первое число квадратом второго числа?");
Console.WriteLine("введите первое целое число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе целое число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB * numberB)
{
    Console.WriteLine("да");
}
else 
{
    Console.WriteLine("нет");
}
