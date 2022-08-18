
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 int number = new Random().Next(10000, 99999);
//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());
string pol = Convert.ToString(number);

if (pol.Length == 5)
{
    if (pol[0] == pol[4] && pol[1] == pol[3])
    {
        Console.WriteLine($"Число {number} палиндром");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}


// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки A: ");
double a = double.Parse(Console.ReadLine());
string a1 = Convert.ToString(a);

Console.WriteLine("Введите координаты точки B: ");
double b = double.Parse(Console.ReadLine());
string b1 = Convert.ToString(b);

double ab = Math.Sqrt(Math.Pow((b1[0] - a1[0]) , 2) + 
                      Math.Pow((b1[1] - a1[1]) , 2) + 
                      Math.Pow((b1[2] - a1[2]) , 2));
Console.WriteLine($"Расстояние между A и B -> {ab:f2}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int j = int.Parse(Console.ReadLine());

for (int i = 1; i < j; i++)
{
   Console.WriteLine(i * i * i);
}

