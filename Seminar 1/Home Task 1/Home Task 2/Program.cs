// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 
        Console.Write("Enter the number a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the number b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter the number c: ");
        int c = int.Parse(Console.ReadLine());

        int max = c;

        if (a > b && a > c)
        {
            max = a;
        }
        else if (b > c)
                  {
            max = b;
                        }
                 else
                       {
                 max = c;}