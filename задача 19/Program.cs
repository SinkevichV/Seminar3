/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
if (9999 < number & number < 100000)
{
    string numberString = number.ToString();
    if (numberString[0] == numberString[4] && numberString[1] == numberString[3])
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
        Console.WriteLine($"Число {number} не является палиндромом");
}
else
    Console.WriteLine("Введено не пятизначное число!");
