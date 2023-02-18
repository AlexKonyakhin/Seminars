//Задание1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart (int x, int y)
{
    if (x > 0 && y > 0) 
    {
        return  1;
    }
    if (x < 0 && y > 0) return  2;
    if (x < 0 && y < 0) return  3;
    if (x > 0 && y < 0) return  4; 
    return 0;
}
Console.WriteLine("Inrut X:" );
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Inrut Y:" );
int Y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindQuart(X, Y));


