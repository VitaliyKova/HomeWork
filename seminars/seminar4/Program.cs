//Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// int Digitcount(int num)
// {
//     int count = 0;
//     while(num > 0)
//     {
//         count++;
//         num /= 10;
//     }
//     return count;
// }

// Console.WriteLine("Input number");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Number of digits in {num} -> {Digitcount(num)}");

//Задача 4. Напишите программу, которая выводит массив из n элементов, заполненный числами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] CreatRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return newArray;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("write Size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write minValue");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("write maxValue");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreatRandomArray(size, minValue, maxValue);
// PrintArray(myArray);

//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//4  -> 24
//5  -> 120

// int Factorial(int num)
// {
//     int resultat = 1;
//     for(int i = 1; i <= num; i++)
//     {
//         resultat = resultat * i;
//     }
//     return resultat;
// }

// Console.WriteLine($"Factorial {5} -> {Factorial(5)}");



