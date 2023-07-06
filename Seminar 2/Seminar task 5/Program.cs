// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
 
Console.WriteLine("Enter the number a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the number b");
int b = int.Parse(Console.ReadLine());

// b = a/b - тоже можно как вариант 
if (b == (a/b)) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}

if ((a * a == b)||(b * b == a)) {
    Console.WriteLine("Yes");
} else {
    Console.WriteLine("No");
}
