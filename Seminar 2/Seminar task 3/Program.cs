﻿// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Enter the number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number b");
int b = int.Parse(Console.ReadLine());

if (a % b == 0) {
    Console.WriteLine("Dev");
} else {
    Console.WriteLine("No");
}