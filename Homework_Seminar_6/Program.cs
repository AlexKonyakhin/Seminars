// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Решение № 1.

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);//Выделяем память под массив int[] arr, считываем строку с консоли(Console.ReadLine()), потом методом Split() получаем из строки массив, в качестве разделителей пробелы, затем метод Array.ConvertAll применяется ко всем элементам входного массива функцию, переданную вторым параметром (intParse), таким образом получается массив int
// int count = 0; 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Решение № 2.

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

// void NumbersMoZero(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//     {
//         count++;
//     }   

//     }
//     Console.WriteLine($"Count of numbers more than zero -> {count}");

// }
// Console.WriteLine("Input array size");
// int size = Convert.ToInt32(Console.ReadLine());
// int minValue = Convert.ToInt32(-20);
// int maxValue = Convert.ToInt32(20);

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// NumbersMoZero(myArray);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.Write("Введите k1: ");
// var k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// var b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2 = Convert.ToDouble(Console.ReadLine());

// var x = (b2 - b1) / (k1 - k2);
// var y = k1 * x + b1;

// Console.WriteLine($"Пересечение в точке: ({x};{y})");
