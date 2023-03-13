// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

    // Console.WriteLine("input first number");
    // int num1 = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("input second number");
    // int num2 = Convert.ToInt32(Console.ReadLine());
    // if (num1 > num2)
    // {
    //     Console.WriteLine("First number is MAX");
    // }
    // else
    // {
    //    Console.WriteLine("Second number is MAX");
    // }

    // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22

// Console.WriteLine("input first number");
//  int num1 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("input second number");
//  int num2 = Convert.ToInt32(Console.ReadLine());
//  Console.WriteLine("input third number");
//  int num3 = Convert.ToInt32(Console.ReadLine());
//  int max = num1;
// if (num2 > max);  //cs(33,16): warning CS0642: Возможно, ошибочный пустой оператор //C:Program.cs(37,16): warning CS0642: Возможно, ошибочный пустой оператор 
// {
//     max = num2;
// }
// if (num3 > max);
// {
//     max = num3;
// }
// Console.WriteLine("MAX number is");
// Console.WriteLine(max);

    // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
    // 4 -> да
    // -3 -> нет
    // 7 -> нет
// Console.WriteLine("Проверка чётности.  Пожалуйста введите число");
// int a = Convert.ToInt32(Console.ReadLine());

// if ( a % 2 == 0 )
// {
//     Console.WriteLine($"число {a} чётное");
// }
// else
// {
//     Console.WriteLine("нет, число не чётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Пожалуйста введите число");
int n = Convert.ToInt32(Console.ReadLine());
int num = 1;
while (num <= n)
{
    if (num % 2 == 0)
    {
       Console.Write(num + " ");
    }
    num++; 
}