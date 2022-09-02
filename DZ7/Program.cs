//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine( ));

int[,] result = GetArray(rows,columns,0,10);
PrintArray(result);
 
int[,] GetArray (int m, int n, int min, int max )
{
    int[,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[ , ] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

*/
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите позицию строки: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию столбца: ");
int j = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Введите количество строк: ");
//int rows = int.Parse(Console.ReadLine());
int rows = new Random().Next(3, 6);

//Console.WriteLine("Введите количество столбцов: ");
//int columns = int.Parse(Console.ReadLine( ));
int columns = new Random().Next(3, 6);

int[,] result = GetArrayTwo(rows,columns,0,10);
PrintArray(result);
 
int[,] GetArrayTwo (int m, int n, int minValue, int maxValue )
{
    int[,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        //if (i = i1)
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[ , ] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    if (i < 0 && i < inArray.GetLength(0) && j < 0 && j > inArray.GetLength(1))
            {
                Console.WriteLine("Значение элемента массива = {0}", inArray[i, j]);
            }
            else
            {
                Console.WriteLine("Элемент не существует");
            }
            Console.ReadLine();
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine( ));

int[,] result = GetArray(rows,columns,0,10);
PrintArray(result);
 
int[,] GetArray (int m, int n, int min, int max )
{
    int[,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[ , ] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
             Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(inArray.GetLength(0));
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
    double sum = 0;
       for (int i = 0; i < inArray.GetLength(0); i++)
      {
        sum += inArray[i, j];
      }
      Console.WriteLine($" среднее арифметическое элементов: { sum / inArray.GetLength(0)} ");
    }

}
*/