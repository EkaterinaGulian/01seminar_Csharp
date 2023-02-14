System.Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

if(N > 99 && N < 1000)
{
    System.Console.WriteLine(N%10);
}
else
{
    System.Console.WriteLine("введено не трехзначное число");
}
