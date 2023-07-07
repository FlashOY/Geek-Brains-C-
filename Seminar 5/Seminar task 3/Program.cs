// 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве. 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

bool search (int x, int [] array ) {
    bool result = false;
    for ( int i = 0; i < array.Length; i++)  {
        if ( array[i] == x)
        {
            result = true;
            break; 
        }
    }
    return result;
}

int [] array= {4, -8, 8, 2};
int x = 4; 
bool result  = search(x ,array); 
System.Console.WriteLine($"Result: {string.Join(", ", result)}");




