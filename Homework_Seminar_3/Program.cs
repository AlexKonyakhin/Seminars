// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// void Polindrome(int n)
// {
//     int num1 = n % 10; //последнее число
//     int num2 = n % 100/10; // предпоследнее число
//     int num3 = n / 10000; //первое число
//     int num4 = n / 1000 % 10; // второе число
    
//     if (num1 == num3 && num2 == num4)
//     {
//         Console.WriteLine($"Number {n} is polindrome");
//     }
//     else
//     {
//         Console.WriteLine($"Number {n} is not polindrome");
//     }
// }
// Console.WriteLine("Введите пятизначное число: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Polindrome(q);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double xb, double yb, double za, double zb)
//     {
//         return Math.Round(Math.Sqrt(Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2) ),2);
//     }
// Console.WriteLine("Inrut coordinate X for first point:" );
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate Y for first point:" );
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate Z for first point:" );
// double za = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate X for second point:" );
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate Y for second point:" );
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate z for second point:" );
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points => {FindDistance(xa, ya, xb, yb, za, zb)}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Cube(int num)
// {
//     int counter = 1;
//     while (counter <= num)
//     {
//         Console.WriteLine($"{counter} -> {Math.Pow(counter, 3)} ");
//         counter++;
//     }

// }
// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Cube(n);


