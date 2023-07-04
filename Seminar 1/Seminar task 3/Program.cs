// Напишите программу, которая будет выдавать название дня недели по заданному номеру.


Console.Write("Enter the number of week: ");
int w_num = int.Parse(Console.ReadLine());


//Можно добвать проверку вначале if ((w_num >=1) && (number <=7))

if (w_num == 1) {
    Console.WriteLine("Monday!");
} else if (w_num == 2) {
    Console.WriteLine("Tuesday!");
} else if (w_num == 3) {
    Console.WriteLine("Wednesday!");
} else if (w_num == 4) {
    Console.WriteLine("Thursday!");
} else if (w_num == 5) {
    Console.WriteLine("Friday!");
} else if (w_num == 6) {
    Console.WriteLine("Saturday!");
} else if (w_num == 7) {
    Console.WriteLine("Sunday!");
} else {
    Console.WriteLine("Not correct number of the week!");
}