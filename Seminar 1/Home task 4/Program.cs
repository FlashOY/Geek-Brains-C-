﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

 Console.Write("Enter the number N:");

 int N = int.Parse(Console.ReadLine());

 for (int i = 1; i <=N; i++ )
 { if (i % 2 == 0)   { Console.WriteLine($"The number is . {i}");
 }
 } 