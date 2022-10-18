// Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до (А).
//

int GetSum (int A)
{
    int sum = 0;
    
    for (int i = 1; i <= A; i++)
    {
        sum += i; // sum = sum + 1;
    }
    return sum;
}

Console.Clear();
Console.Write("Введите число A: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetSum(n));
