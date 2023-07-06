// Напишите процграмму, которая примет на вход число от пользователя и выведет на экран кол-во цифр в этом числе. Число может быть любой разрядности. 
// 43 is 2 
Console.WriteLine ("Enter the number");
int a = int.Parse(Console.ReadLine()); 
int count = 1; 
while (a/10 !=0) {
    a = a/10; 
    count++;
}

Console.WriteLine ($"count is {count}");