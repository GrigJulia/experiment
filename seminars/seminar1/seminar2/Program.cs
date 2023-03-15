    // Напишите программу, которая вывыодит случайное число из отрезка [10, 99 ] и показывает наибольшую цыфру числа.
    // 78 - > 8
    // 12 - > 2
    // 85 - > 8
// int BiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;

//     if (dec > ed) return dec;
//     else return ed;
// }
// int randomnum = new Random().Next(10, 100); //если 99 тоже надо включить, то пишем до 100 или 99+ 1
// int res = BiggestDigit(randomnum);
// Console.WriteLine($"Biggest Digit of {randomnum} -> {res}");

    //Напишите програму, котороаяс ввыводит случайное трёхзначное число и удаляет вторую цифру этого числа.
    // 456 -  46
    // 782 - 72
    // 918 - 98

// int Deletedigit(int num)  //передаём методу сгенерир число.
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }

// int randomnum = new Random().Next(100, 1000);
// Console.WriteLine(randomnum);
// Console.WriteLine(Deletedigit(randomnum));  //int result = Deletedigit(randomnum);

    // напишите программу, которая на вход принимает число и проверяет кратно ли оно одновременно 7 и 23.
    //14
    //46
    //161

// bool kratnum(int num)
// {
//     return num % 7 == 0 && 23 == 0;
// }
// int randomnum = new Random().Next(1, 1000);
// Console.WriteLine(randomnum);
// Console.WriteLine(kratnum(randomnum));

    // Напишите программу, которая принимает на вход два числа и проверяет является ли одно число квадратом другого.
// bool Quad (int num1, int num2)
// {
//     return num1 * num1 == num2 | num2 *num2 == num1;
// }
// int randomnum1 = new Random().Next(1, 1000);
// int randomnum2 = new Random().Next(1, 1000);

// Console.WriteLine(randomnum1);
// Console.WriteLine(randomnum2);
// Console.WriteLine(Quad(randomnum1, randomnum2));

    // Напишите программу которая на вход принимает два числа и выводит, является ли второе число квадратом первому. Если второе число не кратно первому, то программа выводит остаток деления.
    // 34, 5 -> не кратно, остаток 4
    // 16, 4 -> кратно
// void  Krad(int num1, int num2)
// {
//     int res = num1 % num2;
//     if (res == 0) Console.WriteLine($"Кратно");
//     else Console.WriteLine($"не кратно, {res}");


// }
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// Krad(num1, num2);

//if (Krad(randomnum1, randomnum2) == 0) Console.WriteLine($"Кратно");
//else Console.WriteLine($"не кратно, {Krad(randomnum1, randomnum2)}");
