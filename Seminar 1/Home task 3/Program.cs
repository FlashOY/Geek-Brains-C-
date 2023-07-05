// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).
 Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
