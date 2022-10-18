// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int CountNumber(int a)
{
    int count = 0;
    if(a==0)
    {
        return 1;
    }
    while(a > 0 || a < 0)
    {
        count ++;
        a = a / 10;
    }
    return count;
}

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(CountNumber(n));
