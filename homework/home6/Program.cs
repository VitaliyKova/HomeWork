/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

// void Printarray (int [] MyArray)
// {
//     for(int i = 0; i < MyArray.Length; i++)
//     {
//         Console.Write($"{MyArray[i]} ");
//     }
//     Console.WriteLine();
// }

// int[] NewArray (int size)
// {
//     int [] array = new int [size];
//     Console.WriteLine($"Введите {size} чисел");
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// int CountPositive (int [] MyArray)
// {
//     int count = 0;
//     for(int i = 0; i < MyArray.Length; i++)
//     {
//         if(MyArray[i] > 0) count++;
//     }
//     return count;
// }


// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] MyArray = NewArray(size);

// Console.WriteLine($"Пользователь ввел {CountPositive(MyArray)} положительных чисел");



/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/