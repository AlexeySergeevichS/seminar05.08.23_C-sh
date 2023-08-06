// Задача №7. Напишите программу, которая принимает 
// на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8
Console.Write("Введи трехзначное число : ");
int number = int.Parse(Console.ReadLine()!);
int firstDigit = number / 100;
int secondDigit = number / 10 % 10;
int thirdDigit = number % 10;
Console.Write($"Перая цифра числа {number} равна {firstDigit}, вторая {secondDigit}, третья {thirdDigit}");
