// Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetDegree (int n, int m)
{
    int Degree = 1;
    int i = 0;
    while (i < m)
    {
       Degree = Degree * n;
       i = i + 1;
    }
    return Degree;
}

Console.Write("Введите число A: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write(GetDegree(x, y));