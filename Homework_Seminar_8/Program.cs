// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);

//         }
//     }

//     return newArray;
// }

// void Show2DArray(int[,] array)
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
// int[,] Sortirovka(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//     }
//     return array;
// }
// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(myArray);
// myArray = Sortirovka(myArray);
// Show2DArray(myArray);

//**************************************************************************************************
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] Create2DRandomArray(int colums, int rows, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, colums];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return newArray;
// }

// void Show2DArray(int[,] array)
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
// void MinSumString(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int k = 0; k < array.GetLength(1); k++)
//     {
//         minRow += array[0, k]; //получаем сумму минимальной строки
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             sumRow += array[i, j]; // вычисляем суммы каждой строки
//         if (sumRow < minRow) // сравниваем каждую строку поочереди с минимальной
//         {
//             minRow = sumRow; // если какая-то строка меньше минимальной, то присваем новую мин строку
//             minSumRow = i; // присваиваем номер минимальной строки
//         }
//         sumRow = 0; 

//     }
//     Console.Write($"{minSumRow + 1} строка"); // добавляем один, чтобы корректно считал, не от нуля
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int[,] Myarray = Create2DRandomArray(columns, rows, minValue, maxValue);
// Show2DArray(Myarray);
// MinSumString(Myarray);


//****************************************************************************************************************************************************************

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// using System;

// namespace MatrixMultiplication;

// class Example
// {
//     static void Main(string[] args)
//     {
//         //Задаём размеры матриц 2*3 и 3*3, также индексы i и j 

//         int m = 2, n = 3, p = 3, q = 3, i, j;

//         //Сначала отображаются две матрицы a и b

//         int[,] a = new int[m, n];
//         Random rnd = new Random();
//         Console.WriteLine("Matrix a:");
//         for (i = 0; i < m; i++)
//         {
//             for (j = 0; j < n; j++)
//             {
//                 a[i, j] = rnd.Next(1, 5);
//                 Console.Write(a[i, j] + " ");
//             }
//             Console.WriteLine();
//         }

//         int[,] b = new int[p, q];

//         Console.WriteLine("Matrix b:");
//         for (i = 0; i < p; i++)
//         {
//             for (j = 0; j < q; j++)
//             {
//                 b[i, j] = rnd.Next(1, 5);
//                 Console.Write(b[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//         //Если количество столбцов в первой матрице не равно количеству строк во второй матрице, то матрицы не могут быть умножены

//         if (n != p)
//         {
//             Console.WriteLine("Matrix multiplication not possible");

//         }

//         //Произведение матриц a и b, т.е. матрица c. Затем отображается матрица c
//         else
//         {
//             int[,] c = new int[m, q];
//             for (i = 0; i < m; i++)
//             {
//                 for (j = 0; j < q; j++)
//                 {
//                     c[i, j] = 0;
//                     for (int k = 0; k < n; k++) 
//                     {
//                         c[i, j] += a[i, k] * b[k, j];
//                     }
//                 }
//             }
//             Console.WriteLine("Result of multiplication two matrix:");
//             for (i = 0; i < m; i++)
//             {
//                 for (j = 0; j < n; j++)
//                 {
//                     Console.Write(c[i, j] + " ");
//                 }
//                 Console.WriteLine();
//             }
//         }
//     }
// }


//************************************************************************************************
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] Create3DRandomArray(int colums, int rows, int field)
// {
//     int[,,] newArray = new int[rows, colums, field];

//     int count = 10;
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < newArray.GetLength(2); k++)
//             {
//                 newArray[i, j, k] += count;
//                 count += 3;
//             }
//         }
//     }
//     return newArray;
// }

// void Show3DArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]}({i},{j},{k})");
//             }

//         }

//     }
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of field: ");
// int field = Convert.ToInt32(Console.ReadLine());
// int[,,] myArray = Create3DRandomArray(columns, rows, field);
// Show3DArray(myArray);

//************************************************************************************************
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 9;
// int[,] Spiral = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= Spiral.GetLength(0) * Spiral.GetLength(1))
// {
//     Spiral[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < Spiral.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= Spiral.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > Spiral.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// WriteArray(Spiral);

// void WriteArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write("0" + array[i,j] + " " );

//             else Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }




