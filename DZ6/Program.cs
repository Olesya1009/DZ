// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int size = new Random().Next(2,10);
int[] array = GetArray(size,-50,100);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
int sum = 0;
int array1 = array.Length;
for (int i = 0; i < array1; i++)
{
    if (array[i] > 0)
   {
    sum ++;
   }
//Console.WriteLine($"{sum} чисел больше 0 ввёл пользователь");
}
Console.WriteLine($"{sum} чисел больше 0 ввёл пользователь");


