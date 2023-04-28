/*
Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

// Console.WriteLine("Введите трехзначное число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num <= 999 && num >= 100)
// {
//     int secDigit = (num / 10) % 10;
//     Console.WriteLine($"Вторая цифра в числе {num} -> {secDigit}");
// }
// else Console.WriteLine("Введены некорректные данные!");

/*
Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.
*/

// Данный вариант работает только с трехзначными числами

// Console.WriteLine("Введите число");                             
// int num = Convert.ToInt32(Console.ReadLine());
// if(100 <= num && num <= 999)
// {
//     Console.WriteLine($"Третья цифра в числе {num} -> {num % 10}");
// }
// else Console.WriteLine($"В числе {num} третьей цифры нет!");

// Эта версия работает с любым числом(В диапозоне int)

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num < 100 && num > -100)
// {
//     Console.WriteLine($"В числе {num} третьей цифры нет");
// }
// else if(num > 0)
// {
//     int num1 = num;
//     while(num > 1000)
//     {
//         num /= 10;
//     }
//     Console.WriteLine($"Третья цифра числа {num1} -> {num % 10}");
// }
// else if(num < 0)
// {
//    int num1 = num;
//     while(num < -1000)
//     {
//         num /= 10;
//     }
//     Console.WriteLine($"Третья цифра числа {num1} -> {(num % 10) * -1}"); 
// }


/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
*/

// Console.WriteLine("Введите цифру, обозначающую день недели");
// int day = Convert.ToInt32(Console.ReadLine());
// if(day < 0 || day > 7) Console.WriteLine("Цифра введена некорректно");
// else if(day == 6 || day == 7) Console.WriteLine($"{day} -> выходной день");
// else Console.WriteLine($"{day} -> рабочий день");