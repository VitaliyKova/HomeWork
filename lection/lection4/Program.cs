// string Method(int count, string text)
// {
//     string result = string.Empty;
//     for(int i = 0; i < count;i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method(10, "z");
// Console.WriteLine(res);


// ЗАДАЧА

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//   ЗАДАЧА

// string text = "Я думаю что это все круто";

// string Replace(string text, char old, char newV)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for (int i =0; i < length; i++)
//     {
//         if(text[i] == old) result = result + $"{newV}";
//         else result = result + $"{text[i]}";    
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'у', 'У');
// Console.WriteLine(newText);


// ЗАДАЧА

// int [] arr = {1,5,4,3,2,6,7,1,1};

// void PrintArr(int [] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//        Console.Write($"{array[i]} "); 
//     }
//     Console.WriteLine();  
// }


// void SelectionSort(int [] array)
// {
//     //int length = array.Length;
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;
//         int temporary = array[i];
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[j] < array[minPosition]) minPosition = j; 
//         }               
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }

// }
// PrintArr(arr);
// SelectionSort(arr);
// PrintArr(arr);
