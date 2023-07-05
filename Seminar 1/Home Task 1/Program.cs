// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

 Console.Write("Enter the number a:");

 int a = int.Parse(Console.ReadLine());

Console.Write("Enter the number b:");

int b = int.Parse(Console.ReadLine());

int max =0;


if (a > b) {
    max = a;
    Console.WriteLine("a biggest then b!");
} else {  max = b;
Console.WriteLine("b biggest then a!");
}

