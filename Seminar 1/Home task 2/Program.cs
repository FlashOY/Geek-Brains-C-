// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

 Console.Write("Enter the number a:");

 int a = int.Parse(Console.ReadLine());

Console.Write("Enter the number b:");

int b = int.Parse(Console.ReadLine());

Console.Write("Enter the number c:");

int c = int.Parse(Console.ReadLine());

int v_max =c;
// Добавлено условие на равенство a, b и c
if (a == b && b == c)  {
    Console.Write($"All the nubers equal - {a}");
} else {
            if (a > b && a > c) {
                v_max = a;
                } else if  (b > c) {
                     v_max = b;
                        } else {
                            v_max = c;
                                    }
}

Console.WriteLine($" Biggest number is - {v_max}");
        

 



 