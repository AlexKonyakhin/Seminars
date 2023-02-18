// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

void Polindrome(int n)
{
    int num1 = n % 10; //последнее число
    int num2 = n % 100/10; // предпоследнее число
    int num3 = n / 10000; //первое число
    int num4 = n / 1000 % 10; // второе число
    
    if (num1 == num3 && num2 == num4)
    {
        Console.WriteLine($"Number {n} is polindrome");
    }
    else
    {
        Console.WriteLine($"Number {n} is not polindrome");
    }
}
Console.WriteLine("Введите пятизначное число: ");
int q = Convert.ToInt32(Console.ReadLine());
Polindrome(q);



