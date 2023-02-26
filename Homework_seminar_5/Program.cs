// // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// // [345, 897, 568, 234] -> 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void CountEvenNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         count += (array[i] + 1) % 2;
//         // count += array[i] % 2==0? 1 : 0; //условие оправдана? тогда выполнить это:иначе выполнить это

//     }
//     Console.WriteLine($"Count of Even numbers in array -> {count}");

// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = Convert.ToInt32(100);
// int maxValue = Convert.ToInt32(999);

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// CountEvenNumbers(myArray);


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SumOddNumbers(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i += 2)
//     {
//         sum += array[i];
//     }
//     Console.WriteLine($"Sum of Odd elements in array -> {sum}");

// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// SumOddNumbers(myArray);


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// double[] CreateRandomArray(int size)

// {
//     Random rnd = new Random();
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = Math.Round(rnd.NextDouble() * 20, 2);
//     }
//     return array;
// }
// void ShowArray(double[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine("]");
// }

// void DiffBetMaxMin(double[] array)
// {
//     double max = array[0];
//     double min = array[0];

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
//     Console.WriteLine($"Всего {array.Length} чисел. Максимальное значение = {Math.Round(max, 2)}, минимальное значение = {Math.Round(min, 2)}");
//     Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round(max - min, 2)}");
// }
// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] array = CreateRandomArray(size);
// Console.WriteLine("массив: ");
// ShowArray(array);
// DiffBetMaxMin(array);






