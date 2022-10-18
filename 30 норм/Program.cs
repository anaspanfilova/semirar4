// Напишите программу, которая выводит массим из 8 элементов, заполненный нулями и еденицами в случайном порядке.
// [1,0,1,1,0,1,0,0]





int[] RandomArr()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;


}
void PrintArray(int[] mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");
        }
    }
}

int [] N = RandomArr();
PrintArray(N);
