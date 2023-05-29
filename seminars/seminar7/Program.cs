//Задача 1. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

// int [,] Creat2DRandomArray (int rows, int colums, int minValue, int maxValue)
// {
//     int [,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }



// Console.WriteLine("write rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write colums");
// int colums = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Print2DArray(Creat2DRandomArray(rows,colums,minValue,maxValue));

//Задача 4. задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// int [,] Creat2DRandomArray (int rows, int colums, int minValue, int maxValue)
// {
//     int [,] array = new int[rows, colums];
//     for(int i = 0; i < rows; i++)
//     {
//         for(int j = 0; j < colums; j++)
//         {
//             array[i,j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int SumDiag (int [,] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         if(i == j)
//         {
//             sum = sum + array[i,j];
//         }

//     }
//     return sum;   
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
// Console.WriteLine($"{SumDiag(myArray)}");




//Задача 3.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


//Задача 2. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.