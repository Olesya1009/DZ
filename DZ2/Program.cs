/*
// Задача 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int num1 = number/100;
int num2 = number/10;
int num3 = number%10;
int num4 = num2%10;

Console.WriteLine($"Вторая цифра {num4}");
*/
// Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num = new Random().Next(1,10000);
Console.WriteLine($"Наше число:{num}");
string num1 = Convert.ToString(num);
if (num1.Length > 2)
{
  Console.WriteLine($"Нужный номер  {num1[2]}");
}
else
{
  Console.WriteLine($"В числе меньше трёх цифр");
}
/*

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number == 1)
{
  Console.WriteLine($"{number} - понедельник, не является выходным");
}
if (number == 2)
{
  Console.WriteLine($"{number} - вторник, не является выходным");
}
if (number == 3)
{
  Console.WriteLine($"{number} - среда, не является выходным");
}
if (number == 4)
{
  Console.WriteLine($"{number} - четверг, не является выходным");
}
if (number == 5)
{
  Console.WriteLine($"{number} - пятница, не является выходным");
}
if (number == 6)
{
  Console.WriteLine($"{number} - суббота,  выходной");
}
if (number == 7)
{
  Console.WriteLine($"{number} - воскресенье, выходной");
}

*/