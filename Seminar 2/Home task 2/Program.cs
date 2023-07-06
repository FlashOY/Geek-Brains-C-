// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет.

Console.WriteLine("Enter the number: ");
int number = int.Parse(Console.ReadLine());

if (number < 100 ) 
{Console.WriteLine("Incorrect number");
}


int temp = Math.Abs(number);
while (temp >= 1000 ){
    temp = temp / 10; 
} 

int result = temp % 10; 
Console.WriteLine($"Third number {result}");