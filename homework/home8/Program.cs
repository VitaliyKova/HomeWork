/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// РЕШЕНИЕ

// int[,] Creat2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] sorted(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int q = 0; q < array.GetLength(1) - 1 - j; q++)
//             {
//                 if (array[i, q] < array[i, q + 1])
//                 {
//                     int box = array[i, q];
//                     array[i, q] = array[i, q + 1];
//                     array[i, q + 1] = box;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Creat2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(MyArray);
// MyArray = sorted(MyArray);
// Print2DArray(MyArray);


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//РЕШЕНИЕ

// int[,] Creat2DRandomArray(int rows, int colums, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] SumRows (int [,] array)
// {
//     int [] temp = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int summa = 0;
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             summa += array[i,j];
//         }
//         temp[i] = summa;
//     }
//     return temp;
// }

// void MinSum (int[] array)
// {
//     int min = array[0];
//     int rows = 0;
//     for(int k = 0; k < array.Length; k++)
//     {
//         if(array[k] < min) 
//         {
//             min = array[k];
//             rows = k;
//         }
//     }
//     Console.WriteLine($"В строке {rows + 1} минимальная сумма элементов, которая равна {min}");
// }

// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Creat2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(MyArray);
// int[] temp = SumRows(MyArray);
// MinSum(temp);