//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int [] a= {-4, -8, 8, 2};
 

int [] sort  (int [] array) {

    for (int i = 0; i < array.Length; i++) 
    {
           array[i] = - array[i];
    }

 
   return   array; 
}
 
int [] result  = sort(a); 
System.Console.WriteLine($"Result: {string.Join(", ", result)}");
