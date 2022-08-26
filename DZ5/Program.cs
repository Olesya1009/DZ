/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = GetArray(6,100,1000);
Console.WriteLine(string.Join(" ", array));
int array1 = array.Length;
int sum =0;

 for (int i = 0; i < array1; i++)
 {
    if (array[i] %2 == 0)
    {
        sum++;
    }
 }

 Console.WriteLine($"количество чётных чисел в массиве: {sum} ");

int[] GetArray(int size, int minnumber, int maxnumber)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minnumber, maxnumber+1);
    }
    return res;
}


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = GetArray(10,1,100);
Console.WriteLine(String.Join(" ",array));
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int array1 = array.Length;
int Oddsum = 0;

for (int i = 0; i < array1; i++)
{
    if (i %2 == 1)
    {
        Oddsum += array[i];
    }
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {Oddsum} ");
*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] array = GetArray(6,1,100);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minnumber, int maxnmber)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minnumber, maxnmber+1);
    }
    return res;
}
int min = array[0];
int max = array[0];

int array1 = array.Length;
for (int i = 0; i < array1; i++)
{
    if (array[i] > max) max = array[i];
}
 Console.WriteLine($"{max}");
 for (int j = 0; j < array1; j++)
{
    if (array[j] < min) min = array[j];
} 
Console.WriteLine(min);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {max - min} ");


