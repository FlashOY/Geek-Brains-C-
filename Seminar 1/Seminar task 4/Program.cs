// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Enter the number");
int a = int.Parse(Console.ReadLine());
if(a > 99 && a <1000) {     //&& - and 
    //целочисленный остаток от деления , в  данном случае  последний  знак от деления %
    int b = a % 10; 
    Console.WriteLine($" the last number = {b}");
} else {
    Console.WriteLine("Incorrect number!");
}