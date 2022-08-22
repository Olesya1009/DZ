
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine());
int count = b;

int result = Convert.ToInt32(Math.Pow(a , b));
//int  a = a * a;
//count++;
Console.WriteLine($"число {a} в степени {b} равно {result}");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//int num = new Random().Next(10, 1000);
//Console.Write("Число: {num}");
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num1 = Convert.ToString(num);
int sum = 0;
for (int i = 0; i < num1.Length; i++)
{
    sum  += num1[i];
    num++;
      
}
Console.Write($"Сумма цифр в числе {sum}");
   

//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}

void PrintArray(int[] col)
{
     int count = col.Length;
     int position = 0;
     Console.Write('[');
     while (position < count)
     {
        Console.Write(col[position]);
        Console.Write(' ');
        position++;
     }
     Console.Write(']');
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);

