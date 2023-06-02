/*Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

//int[,] RowsToColoms (int [,] array)
// {
//     if (array.GetLength(0) != array.GetLength(1))
//     {
//         Console.WriteLine("NO");
//         return array;
//     }
//     else
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < array.GetLength(1); j++)
//             {
//                 int temp = array[i, j];
//                 array[i, j] = array[j, i];
//                 array[j, i] = temp;
//             }
//         }
//         return array;
//     }
// }

//int [,] Creat2DRandomArray (int rows, int colums, int minValue, int maxValue)
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

//void Print2DArray(int[,] array)
// {
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


// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int [,] myArray = Creat2DRandomArray(rows,colums,minValue,maxValue);

// Print2DArray(myArray);
// RowsToColoms(myArray);
// Print2DArray(myArray);

//Задание 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// то есть удалаем и строку и столбец в которой находится этот элемент

// int[,] ZeroMin(int[,] array)
// {
//     int minimum = array[0, 0];
//     int coord1 = 0;
//     int coord2 = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < minimum)
//             {
//                 minimum = array[i, j];
//                 coord1 = i;
//                 coord2 = j;
//             }
//         }
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == coord1 || j == coord2) array[i, j] = 0;
//         }
//     }
//     return array;

// }

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


// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] Myarray = Creat2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(Myarray);

// Myarray = ZeroMin(Myarray);
// Print2DArray(Myarray);


//Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//8 4 2 4
//5 9 2 3
//1 4 7 2

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

// int[,] ReversRows(int[,] array, int row1, int row2)
// {
//     int box = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         box = array[row2, i];
//         array[row2, i] = array[row1, i];
//         array[row1, i] = box;
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

// Console.WriteLine("Row1");
// int row1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Row2");
// int row2 = Convert.ToInt32(Console.ReadLine());

// int[,] MyArray = Creat2DRandomArray(rows, colums, minValue, maxValue);
// Print2DArray(MyArray);
// MyArray = ReversRows(MyArray, row1-1, row2-1);
// Print2DArray(MyArray);