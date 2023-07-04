// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.



 Console.Write("Enter the number a:");

 int a = int.Parse(Console.ReadLine());

Console.Write("Enter the number b:");

int b = int.Parse(Console.ReadLine());

 


if (b*b ==a) {
    Console.WriteLine("Correct!");
} else {
Console.WriteLine("Not correct!");
}

