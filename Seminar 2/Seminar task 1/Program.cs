// See https://aka.ms/new-console-template for more information
Console.Write("Enter the number: ");
int number = int.Parse(Console.ReadLine());
 int index = 1; 

while (index <= number) {
    Console.WriteLine(index);
    index= index +1; 
}