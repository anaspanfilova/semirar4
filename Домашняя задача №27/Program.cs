// Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum (int a)
{
    int sum = 0;
    
    while(a > 0 || a < 0)
    {
        sum = sum + (a % 10);
        a = a / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(n));