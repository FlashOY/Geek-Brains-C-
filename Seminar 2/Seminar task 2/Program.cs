// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
int randomNumber = new Random().Next(100, 1000);
Console.WriteLine(randomNumber);

//int a = randomNumber /100; 
//int b = randomNumber %10;
//Console.WriteLine(a);
//Console.WriteLine(b);

int result = ((randomNumber/100)*10)+(randomNumber % 10);
Console.WriteLine(result);