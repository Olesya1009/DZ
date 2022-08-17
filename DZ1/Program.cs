/*
//Напишите программу, которая принимает на вход три числа и выдаёт max из этих чисел 
Console.Write("Введите число1: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число2: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Введите число3: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (number2 > number1)
if (number2 > number3)
{
    Console.WriteLine($"число2 {number2} = max");
}
if (number3 > number2)
if (number3 > number1)
{
    Console.WriteLine($"число3 {number3} = max");
}
if (number1 > number3)
if (number1 > number2)
{
    Console.WriteLine($"число1 {number1} = max");
}


// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int a = Math.Abs(number);
if (a % 2 == 0)
{
   Console.WriteLine($"число {number} чётное");
}
if (a % 2 == 1)
{
   Console.WriteLine($"число {number} нечётное");
} 
*/

 // Напишите программу. которая на вход принимает (N), а на выходе показывает все чётные числа от 1 до N.
 Console.Write("Введите число: ");
 int number = int.Parse(Console.ReadLine());
 
int a = 0;
 while(a % 2 == 0)
 while (a <= number)
 {
   Console.WriteLine( a );
   a += 2 ;
}

