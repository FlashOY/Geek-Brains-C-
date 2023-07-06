// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());

if ((number <=999) && (number >= 100)) {
    Console.WriteLine($"Number is {(number/10)%10 }");} 
    else{
        Console.WriteLine("Incorrect number");
        }