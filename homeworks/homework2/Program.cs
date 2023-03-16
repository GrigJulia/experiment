// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// void Two(int num)
// {
//     int num1 = num / 10;
//     int num2 = num1 % 10;
//     Console.WriteLine($"{num} -> {num2}");
// }
// Console.WriteLine("Введите трёхзначное число.");
// int num = Convert.ToInt32(Console.ReadLine());
// Two(num);

    // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

    // 645 -> 5

    // 78 -> третьей цифры нет

    // 32679 -> 6

// int Third(int num)
// {
//     if (num < 100) Console.WriteLine("третьей цифры нет");
//     while (num >1000)
//     {
//         num = num / 10;
//     }
//     return num % 10;
// }
// int randomnum = new Random().Next(1, 10000);
// Console.WriteLine(randomnum);
// Console.WriteLine(Third(randomnum));

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// void Chislo(int num)
// {
//    if (num == 6 | num == 7) Console.WriteLine($"{num} -> да"); 
//    else Console.WriteLine($"{num} -> нет");
// }
// Console.WriteLine("Введите номер дня недели.");
// int num = Convert.ToInt32(Console.ReadLine());
// Chislo(num);
