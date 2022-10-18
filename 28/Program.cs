// Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N.

int GetProduct (int n)
{
    int Product = 1;
    
    for (int i = 1; i <= n; i++)
    {
        Product = Product * i;
    }
    return Product;
}

Console.Clear();
Console.Write("Введите число A: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetProduct(n));
