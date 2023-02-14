//2 ВАРИАНТА РЕШЕНИЯ
// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Введите первое число");
// int numberA = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int max = numberA;
// if (numberA > max) max = numberA;
// if (numberB > max) max = numberB;
// int result = max;
// System.Console.Write("max = ");
// System.Console.WriteLine(result);

System.Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if (numberA > max) max = numberA;
if (numberB > max) max = numberB;

System.Console.Write("max = " + max);

