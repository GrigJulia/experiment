﻿// Console.WriteLine("input number");
// int a = Convert.ToInt32(Console.ReadLine());
// //Console.WriteLine($" Quad of {a} -> {a * a}"); //"You input this number" ->+ a
// int quad = a * a;
// Console.WriteLine(quad);

// Задача 2. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// Console.WriteLine("inrut first number");
// int num1 = Convert.ToInt32(Console.ReadLine ());
// Console.WriteLine("inrut sekond number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if ( num2 * num2 == num1)
// {
//   Console.WriteLine($"first number {num1} is quad of second number {num2}");
// }
// else
// {
//     Console.WriteLine($"first number {num1} is not quad of second number {num2}");
// }
// Задача 3. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"
// Console.WriteLine("input N");
// int n = Convert.ToInt32(Console.ReadLine());

// int current = n * (-1);
// while (current <= n)
// {
//     Console.Write(current + " ");
//     current++;
// }

// Задача 4. 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает **последнюю** цифру этого числа.

// 456 -> 6

// 782 -> 2

// 918 -> 8
// Console.WriteLine("input three-digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 100 && num <= 999)//Уточняем трёхзначность
// {
//     int remainder = num % 10;
//     Console.WriteLine($"Last digit of {num} => {remainder}");
// }
// else
// {
//     Console.WriteLine("Вы ввели не трёхзначное число.");
// }