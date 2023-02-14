// Напишите программу,которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int A = (N%2);
if (A == 0) 
{
    System.Console.WriteLine("да");
}
else
{
    System.Console.WriteLine("нет");
}