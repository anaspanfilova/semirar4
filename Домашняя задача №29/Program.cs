// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



void CheckingNumbers(int num)
{
    if (num == '0'||num == '1'||num == '2'
      ||num == '3'||num == '4'||num == '5'||num == '6'
      ||num == '7'||num == '8'||num == '9'||num == ','
      ||num == '-')
      {}
    else 
      {
        Console.WriteLine($"Ошибка ввода, попробуйте другие цифры");
      }
}

int[] NumArray(string NewNum) // функция  создания и заполнения массива из строки
{ 

  int[] NewNumArray = new int[1];    // инициализация массива из 1 элемента

  int j = 0;

  for (int i = 0; i < NewNum.Length; i++)
    {
        string NewNum1 = "";

        while (NewNum[i] != ',' && i < NewNum.Length)
        {
            NewNum1 += NewNum[i];
            CheckingNumbers(NewNum[i]);

            i++;
        }
        NewNumArray[j] = Convert.ToInt32(NewNum1);    // заполняет массив значениями из строки
        if (i < NewNum.Length - 1)
        {
            NewNumArray = NewNumArray.Concat(new int[] {0}).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return NewNumArray;
}

void PrintArry(int[] coll) // функция  вывода массива на печать 
{ 
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 

Console.Clear();
Console.Write("Введите числа через запятую: ");
string Number = Console.ReadLine();
Number = Number + ","; // дополнительная запятая для обозначения конца строки
int[] NumXArray = NumArray(Number);

if (NumXArray.Length > 8)
{
    Console.WriteLine("Введите числа. ");
}
else
{
    int[] NewNumArray = NumArray(Number);
    PrintArry(NewNumArray);
}
