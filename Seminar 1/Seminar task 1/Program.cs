// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).
//Исходное число
//int number_1 = 5;
//Коментарий для пользователя
Console.WriteLine("Enter the number!");
//Исходное число, которое вводится полоьзователем в консоле
int number = int.Parse(Console.ReadLine());
//Результат: квадрат исходного  числа. 
int result = number*number;

if (number <=10) {
    Console.WriteLine("Your number less then 10!");
} else {
//Console.WriteLine(result);
//Вывести результат с добавлением текста в описании
Console.WriteLine($"Double number result - {result}"); 
}

    Console.WriteLine("The end of the program");

