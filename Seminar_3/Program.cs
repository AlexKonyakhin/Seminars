//Задание1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQuart (int x, int y)
// {
//     if (x > 0 && y > 0) 
//     {
//         return  1;
//     }
//     if (x < 0 && y > 0) return  2;
//     if (x < 0 && y < 0) return  3;
//     if (x > 0 && y < 0) return  4; 
//     return 0;
// }
// Console.WriteLine("Inrut X:" );
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Inrut Y:" );
// int Y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindQuart(X, Y));


// Задача 2. НАпишите программу, которая принимает на вход координаты двух точек. И находит расстояние между ними в 2D пространстве.

// double FindDistance (double xa, double ya, double xb, double yb)
//     {
//         return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2)),2);
//     }
// Console.WriteLine("Inrut coordinate X for first point:" );
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate Y for first point:" );
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate X for second point:" );
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Inrut coordinate Y for second point:" );
// double yb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points => {FindDistance(xa, ya, xb, yb)}");

//Задача 2.Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// string FindDiapazone(int num)
// {
//     if(num == 1) return "x > 0, y > 0";
//     if(num == 2) return "x < 0, y > 0";
//     if(num == 3) return "x < 0, y < 0";
//     if(num == 4) return "x > 0, y < 0";
//     return "Wrong Quadrant";
// }
// Console.WriteLine("Input Quadrant: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(FindDiapazone(q));

//Задача 4. Напишите программу которая принимает на вход число (N) и выдает на консоль квадраты чисел от 1 до N

// void SquareLine(int num)
// {
//     int counter = 1;
//     while (counter <= num)
//     {
//         Console.WriteLine($"{counter} -> {Math.Pow(counter, 2)} ");
//         counter++;
//     }

// }
// Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SquareLine(n);


 

