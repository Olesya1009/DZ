// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Введите количество строк: ");
int rous = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());

int[,] result = GetArray(rous,columns,0,10);
Console.WriteLine();
PrintArray(result);
SubstArray(result);
Console.WriteLine();
PrintArray(result);

int[,] GetArray (int m, int n, int minNumber, int maxNumber )
{
    int[,] array = new int [m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(minNumber, maxNumber + 1);
        }
    }
    return array;
}

void PrintArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SubstArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             for (int l = 0; l < array.GetLength(1) - 1; l++)
            {
                if (array[i, l] < array[i, l + 1])
                {
                    int temp = array[i, l + 1];
                    array[i, l + 1] = array[i, l];
                    array[i, l] = temp;
                }
            }
        }
    }
}
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
     
    double sum = 0;
    double minLine = 0;
    double Line = 0;
       for (int i = 0; i < inArray.GetLength(0); i++)
      {
        sum += inArray[i, 0];
      }
      for (int i = 0; i < inArray.GetLength(1); i++)
      {
        for (int j = 0; j < inArray.GetLength(0); j++) Line += inArray[i, j];
        if (Line < sum)
        {
            sum = Line;
            minLine = i;
        }
        Line = 0;
      }
      Console.WriteLine($" строка: { minLine } ");
}

  