// Задача 19 Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.

string xText;
Console.WriteLine("введите число: ");
xText = Console.ReadLine();

    if ((xText[0] == xText[4]) && (xText[1] == xText[3]))
        Console.WriteLine("Введеное число - палиндром");
    else
        Console.WriteLine("Введеное число - не палиндром");