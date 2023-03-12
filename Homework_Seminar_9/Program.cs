// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void ShowNumbers(int n)
// {
//     if (n >= 1)
//     {
//         Console.Write(n + " ");
//         ShowNumbers(n - 1);
//     }
// }
// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(n);

//******************************************************************
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// void SumElementBeetwen(int M, int N, int sum)
// {
//     if (M > N)
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
//         return;
//     }
//     sum += (M++);
//     SumElementBeetwen(M, N, sum);
// }
// Console.WriteLine("Введите начальное число M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начальное число M:");
// int N = Convert.ToInt32(Console.ReadLine());
// SumElementBeetwen(M, N, 0);

//**************************************************************************************************
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AckermannFunction(int M, int N)
// {
//     if (M == 0) return N + 1;
//     if (M > 0 && N == 0) return AckermannFunction(M - 1, 1);
//     if (M > 0 && N > 0) return AckermannFunction(M - 1, AckermannFunction(M, N - 1));
//     return AckermannFunction(M, N);
// }
// Console.WriteLine("Введите неатрицательное число M:");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите неатрицательное число N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Функция Аккермана для чисел A({M},{N}) = {AckermannFunction(M, N)}");

