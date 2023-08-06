// на вход число и выдает его квадрат
Console.Write("Введи число: ");
//string num=Console.ReadLine()!; // чтобы не было желтой байды в консоле
//int number=int.Parse(num);
int number=int.Parse(Console.ReadLine()!);
int square=number*number;
//Console.WriteLine("Квадрат числа " + num+ " равен "+ square);
Console.WriteLine($"Квадрат числа {number} равен {square}");