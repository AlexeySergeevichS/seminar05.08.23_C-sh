// Задача №1. Напишите программу, 
//которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет
Console.Write("Введи число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введи число B: ");
int B = int.Parse(Console.ReadLine()!);
if (B * B == A)
{
    Console.WriteLine($"Число {A} является квадратом числа {B}");
}
else
{
    Console.WriteLine($"Число {A} НЕ является квадратом числа {B}");
}