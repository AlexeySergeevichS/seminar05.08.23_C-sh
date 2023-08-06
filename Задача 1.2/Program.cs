// Задача №3. Напишите программу, 
// которая будет выдавать название 
// дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введи номер дня недели: ");
int WeekDay = int.Parse(Console.ReadLine()!);
if (WeekDay==1)
{
    Console.Write("Понедельник");
}
else if (WeekDay==2)
{
    Console.Write("Вторник");
}
else if (WeekDay==3)
{
    Console.Write("Среда");
}
else if (WeekDay==4)
{
    Console.Write("Четверг");
}
else if (WeekDay==5)
{
    Console.Write("Пятница");
}
else if (WeekDay==6)
{
    Console.Write("Суббота");
}
else if (WeekDay==7)
{
    Console.Write("Воскресенье");
}
else 
{
    Console.Write("Такого дня недели нету");
}
